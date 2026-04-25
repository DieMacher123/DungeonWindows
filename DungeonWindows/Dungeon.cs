using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DungeonWindows
{
    public partial class Dungeon : Form
    {
        // Zufallsgenerator für Dungeon-Generierung
        private static Random random = new Random();

        // Spielstatus: Dungeon fertig generiert?
        private static bool dungeonFertig = false;

        // Wahrscheinlichkeit für Objekte (Truhen/Fallen)
        private static int objectChance = 5;

        // Dungeon-Größe
        private static int dungeonHeight = 0;
        private static int dungeonWidth = 0;

        // Zähler für Spielobjekte
        private static int fallenCounter = 0;
        private static int truhenCounter = 0;

        // Spielerleben
        private static int heartCounter = 3;

        // Spielerposition im Grid
        int playerX, playerY;

        // 2D-Dungeon-Map (Raster)
        char[,] dungeon = new char[0, 0];

        // Cooldown für Bewegung (verhindert zu schnelles Laufen)
        private Stopwatch moveCooldown = new Stopwatch();
        private int moveDelayMs = 100;

        // fertiges Bild des Dungeons (wird gerendert und nur noch angezeigt)
        private Bitmap dungeonBitmap;

        // Grafiken für Tiles und Spieler
        Image wallImg, floorImg, startImg, exitImg, chestImg, trapImg, playerImg;

        public Dungeon()
        {
            InitializeComponent();

            // Ressourcen laden
            wallImg = Properties.Resources.wall;
            floorImg = Properties.Resources.floor;
            startImg = Properties.Resources.start;
            exitImg = Properties.Resources.exit;
            chestImg = Properties.Resources.chest;
            trapImg = Properties.Resources.trap;
            playerImg = Properties.Resources.player;
        }

        // Startmenü öffnen
        private void startBtn_Click(object sender, EventArgs e)
        {
            mainScreen();
            beendenBtn.Visible = false;
            startBtn.Visible = false;
        }

        // Programm beenden
        private void beendenBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Alternative Exit-Button
        private void beendenBtn2_Click(object sender, EventArgs e)
        {
            beendenBtn_Click(sender, e);
        }

        // Gameover / Win Logik
        private void gameOver()
        {
            if (heartCounter == 0)
            {
                MessageBox.Show("Verloren!");
                Application.Restart();
            }
            else
            {
                if (MessageBox.Show("Spiel gewonnen! Neustarten?", "Gameover", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        // UI vom Hauptmenü anzeigen
        private void mainScreen()
        {
            heightLabel.Visible = true;
            widthLabel.Visible = true;
            objectLabel.Visible = true;

            heightInput.Visible = true;
            widthInput.Visible = true;
            objectInput.Visible = true;

            generateBtn.Visible = true;
            exportBtn.Visible = true;
            helpBtn.Visible = true;
            beendenBtn2.Visible = true;

            heightInput.Text = "40";
            widthInput.Text = "40";
            objectInput.Text = "5";
        }

        // Hilfe / Legende ein-/ausblenden
        private void helpBtn_Click(object sender, EventArgs e)
        {
            dokumentationLabel.Visible = !dokumentationLabel.Visible;
            truheIconLabel.Visible = !truheIconLabel.Visible;
            truhenIcon.Visible = !truhenIcon.Visible;
            falleIconLabel.Visible = !falleIconLabel.Visible;
            fallenIcon.Visible = !fallenIcon.Visible;
            bodenIconLabel.Visible = !bodenIconLabel.Visible;
            bodenIcon.Visible = !bodenIcon.Visible;
            wandIconLabel.Visible = !wandIconLabel.Visible;
            wandIcon.Visible = !wandIcon.Visible;
            endeIconLabel.Visible = !endeIconLabel.Visible;
            endeIcon.Visible = !endeIcon.Visible;
            startIconLabel.Visible = !startIconLabel.Visible;
            startIcon.Visible = !startIcon.Visible;
        }

        // Dungeon erzeugen und Spiel starten
        private void generateBtn_Click(object sender, EventArgs e)
        {
            // Eingabe prüfen
            if (!int.TryParse(heightInput.Text, out int height) ||
                !int.TryParse(widthInput.Text, out int width) ||
                !int.TryParse(objectInput.Text, out int objChance) ||
                height < 10 || height > 40 ||
                width < 10 || width > 40)
            {
                MessageBox.Show("Fehlerhafte Eingabe");
                return;
            }

            // Reset Spielwerte
            heartCounter = 3;
            truhenCounter = 0;
            fallenCounter = 0;

            dungeonHeight = height;
            dungeonWidth = width;
            objectChance = objChance;

            // Dungeon erzeugen + rendern
            dungeon = GenerateDungeon(dungeonHeight, dungeonWidth);
            RenderDungeonBitmap();

            // Bewegung starten
            moveCooldown.Restart();

            // Tastatur aktivieren
            this.KeyPreview = true;
            this.KeyDown += Dungeon_KeyDown;

            // UI aktualisieren
            truhenLabel.Text = $"Truhen: {truhenCounter}";
            fallenLabel.Text = $"Fallen: {fallenCounter}";

            dungeonPanel.Visible = true;
            dungeonPanel.Invalidate();

            // Spieler Startposition suchen
            for (int y = 0; y < dungeon.GetLength(0); y++)
                for (int x = 0; x < dungeon.GetLength(1); x++)
                    if (dungeon[y, x] == 'S') { playerX = x; playerY = y; }

            dungeonFertig = true;

            // UI sichtbar machen
            exportBtn.Enabled = true;
            statistikenLabel.Visible = true;
            truhenLabel.Visible = true;
            fallenLabel.Visible = true;
            heartlbl.Visible = true;
            heartIcon1.Visible = true;
            heartIcon2.Visible = true;
            heartIcon3.Visible = true;
        }

        // Dungeon als Text exportieren
        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (!dungeonFertig) return;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pfad = saveFileDialog.FileName;
                if (Path.GetExtension(pfad) != ".txt") pfad += ".txt";
                File.WriteAllText(pfad, ArrayToText(dungeon));
            }
        }

        // Dungeon zeichnen (statisches Bild + Spieler)
        private void dungeonPanel_Paint(object sender, PaintEventArgs e)
        {
            if (dungeonBitmap == null) return;

            int imageSize = BerechneImgSize(dungeonWidth, dungeonHeight);

            e.Graphics.DrawImage(dungeonBitmap, 0, 0);
            e.Graphics.DrawImage(playerImg, playerX * imageSize, playerY * imageSize, imageSize, imageSize);
        }

        // Dungeon in Bitmap rendern (einmaliges Grid Rendering)
        private void RenderDungeonBitmap()
        {
            int imgSize = BerechneImgSize(dungeonWidth, dungeonHeight);
            dungeonBitmap = new Bitmap(dungeonWidth * imgSize, dungeonHeight * imgSize);

            using (Graphics g = Graphics.FromImage(dungeonBitmap))
            {
                for (int y = 0; y < dungeon.GetLength(0); y++)
                    for (int x = 0; x < dungeon.GetLength(1); x++)
                    {
                        Image img = null;

                        switch (dungeon[y, x])
                        {
                            case '#': img = wallImg; break;
                            case '.': img = floorImg; break;
                            case 'S': img = startImg; break;
                            case 'E': img = exitImg; break;
                            case 'T': img = chestImg; break;
                            case 'F': img = trapImg; break;
                        }

                        if (img != null)
                            g.DrawImage(img, x * imgSize, y * imgSize, imgSize, imgSize);
                    }
            }
        }

        // Dungeon generieren (Maze + Räume + Items)
        public static char[,] GenerateDungeon(int height, int width)
        {
            // ungerade Größe erzwingen
            if (height % 2 == 0) height--;
            if (width % 2 == 0) width--;

            char[,] dungeon = new char[height, width];

            // alles erstmal Wand
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    dungeon[y, x] = '#';

            // Maze erzeugen
            LabyrinthWege(dungeon, 1, 1);

            // zufällige Räume hinzufügen
            int raumAnzahl = Math.Min(50, (width * height) / 50) + random.Next(-2, 3);
            raumAnzahl = Math.Max(2, raumAnzahl);

            for (int r = 0; r < raumAnzahl; r++)
            {
                int rw = random.Next(2, 4);
                int rh = random.Next(2, 4);
                int rx = random.Next(1, width - rw - 1);
                int ry = random.Next(1, height - rh - 1);

                for (int y = ry; y < ry + rh; y++)
                    for (int x = rx; x < rx + rw; x++)
                        dungeon[y, x] = '.';
            }

            // Startpunkt setzen
            int sx, sy;
            do
            {
                sx = random.Next(1, width - 1);
                sy = random.Next(1, height - 1);
            } while (dungeon[sy, sx] != '.');
            dungeon[sy, sx] = 'S';

            // Endpunkt setzen
            int ex, ey;
            do
            {
                ex = random.Next(1, width - 1);
                ey = random.Next(1, height - 1);
            } while (dungeon[ey, ex] != '.' || Math.Abs(ex - sx) + Math.Abs(ey - sy) < 8);
            dungeon[ey, ex] = 'E';

            // Items platzieren
            for (int y = 1; y < height - 1; y++)
                for (int x = 1; x < width - 1; x++)
                    if (dungeon[y, x] == '.' && random.Next(100) < objectChance)
                    {
                        if (random.Next(2) == 0)
                        {
                            dungeon[y, x] = 'T';
                            truhenCounter++;
                        }
                        else
                        {
                            dungeon[y, x] = 'F';
                            fallenCounter++;
                        }
                    }

            return dungeon;
        }

        // Maze Algorithmus
        private static void LabyrinthWege(char[,] dungeon, int y, int x)
        {
            dungeon[y, x] = '.';

            int[][] dirs =
            {
                new int[] { 0, 2 },
                new int[] { 0, -2 },
                new int[] { 2, 0 },
                new int[] { -2, 0 }
            };

            // Richtung randomisieren
            for (int i = 0; i < dirs.Length; i++)
            {
                int r = random.Next(dirs.Length);
                var tmp = dirs[i]; dirs[i] = dirs[r]; dirs[r] = tmp;
            }

            foreach (var d in dirs)
            {
                int nx = x + d[1], ny = y + d[0];

                if (ny > 0 && ny < dungeon.GetLength(0) - 1 &&
                    nx > 0 && nx < dungeon.GetLength(1) - 1 &&
                    dungeon[ny, nx] == '#')
                {
                    dungeon[y + d[0] / 2, x + d[1] / 2] = '.';
                    LabyrinthWege(dungeon, ny, nx);
                }
            }
        }

        // Dungeon Array -> Text
        private static string ArrayToText(char[,] dungeon)
        {
            string txt = "";

            for (int y = 0; y < dungeon.GetLength(0); y++)
            {
                for (int x = 0; x < dungeon.GetLength(1); x++)
                {
                    txt += dungeon[y, x];
                    txt += "\n";
                }
            }

            return txt;
        }

        // Img Größe berechnen (Zoom abhängig von Größe)
        private int BerechneImgSize(int w, int h)
        {
            int maxSize = Math.Max(w, h);

            if (maxSize < 10) maxSize = 10;
            if (maxSize > 40) maxSize = 40;

            double t = (maxSize - 10) / 30;
            int ts = (int)(30 - t * (30 - 17));

            return Math.Max(17, Math.Min(30, ts));
        }

        // Spielerbewegung + Interaktion
        private void Dungeon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.W &&
                e.KeyCode != Keys.A &&
                e.KeyCode != Keys.S &&
                e.KeyCode != Keys.D) return;

            // Movement-Cooldown
            if (moveCooldown.ElapsedMilliseconds < moveDelayMs) return;
            moveCooldown.Restart();

            int nx = playerX, ny = playerY;

            if (e.KeyCode == Keys.W) ny--;
            else if (e.KeyCode == Keys.S) ny++;
            else if (e.KeyCode == Keys.A) nx--;
            else if (e.KeyCode == Keys.D) nx++;

            // Kollision Wand/Border
            if (nx <= 0 ||
                ny <= 0 ||
                nx >= dungeon.GetLength(1) - 1 ||
                ny >= dungeon.GetLength(0) - 1) return;

            if (dungeon[ny, nx] != '#')
            {
                playerX = nx; playerY = ny;

                // Truhe
                if (dungeon[ny, nx] == 'T')
                {
                    dungeon[ny, nx] = '.';
                    truhenCounter--;

                    if (heartCounter < 3) heartCounter++;

                    RenderDungeonBitmap();
                }

                // Falle
                if (dungeon[ny, nx] == 'F')
                {
                    dungeon[ny, nx] = '.';
                    fallenCounter--;

                    if (heartCounter > 0) heartCounter--;

                    RenderDungeonBitmap();
                }

                // Ziel
                if (dungeon[ny, nx] == 'E')
                {
                    gameOver();
                }

                // Leben UI
                switch (heartCounter)
                {
                    case 0: gameOver(); break;
                    case 1:
                        heartIcon1.Visible = true;
                        heartIcon2.Visible = false;
                        heartIcon3.Visible = false;
                        break;
                    case 2:
                        heartIcon1.Visible = true;
                        heartIcon2.Visible = true;
                        heartIcon3.Visible = false;
                        break;
                    case 3:
                        heartIcon1.Visible = true;
                        heartIcon2.Visible = true;
                        heartIcon3.Visible = true;
                        break;
                }

                dungeonPanel.Invalidate();
            }
        }

        private void Dungeon_Load(object sender, EventArgs e) { }

        private void heightLabel_Click(object sender, EventArgs e) { }

        private void widthLabel_Click(object sender, EventArgs e) { }

        private void heightInput_TextChanged(object sender, EventArgs e) { }

        private void widthInput_TextChanged(object sender, EventArgs e) { }

        private void objectLabel_click(object sender, EventArgs e) { }

        private void objectInput_TextChanged(object sender, EventArgs e) { }

        private void dungeonAusgabe_TextChanged(object sender, EventArgs e) { }

        private void dungeonName_TextChanged(object sender, EventArgs e) { }

        private void dungeonNameLabel_Click(object sender, EventArgs e) { }

        private void pathBox_TextChanged(object sender, EventArgs e) { }

        private void pathLabel_Click(object sender, EventArgs e) { }

        private void truhenLabel_Click(object sender, EventArgs e) { }

        private void fallenLabel_Click(object sender, EventArgs e) { }

        private void statistikenLabel_Click(object sender, EventArgs e) { }

        private void timerLabel_Click(object sender, EventArgs e) { }

        private void fallenLabel_Click_1(object sender, EventArgs e) { }

        private void truhenLabel_Click_1(object sender, EventArgs e) { }

        private void truheIconLabel_Click(object sender, EventArgs e) { }

        private void truhenIcon_Click(object sender, EventArgs e) { }

        private void falleIconLabel_Click(object sender, EventArgs e) { }

        private void bodenIconLabel_Click(object sender, EventArgs e) { }

        private void wandIcon_Click(object sender, EventArgs e) { }

        private void wandIconLabel_Click(object sender, EventArgs e) { }

        private void endeIconLabel_Click(object sender, EventArgs e) { }

        private void startIconLabel_Click(object sender, EventArgs e) { }

        private void fallenIcon_Click(object sender, EventArgs e) { }

        private void startIcon_Click(object sender, EventArgs e) { }

        private void bodenIcon_Click(object sender, EventArgs e) { }

        private void endeIcon_Click(object sender, EventArgs e) { }

        private void dokumentationLabel_Click(object sender, EventArgs e) { }

    }
}