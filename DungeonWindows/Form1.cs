using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DungeonWindows
{
    public partial class Form1 : Form
    {
        private static Random random = new Random();

        private static bool dungeonFertig = false;
        private static int objectChance = 5;
        private static int dungeonHeight = 0;
        private static int dungeonWidth = 0;
        private static int fallenCounter = 0;
        private static int truhenCounter = 0;

        char[,] dungeon = new char[0, 0];

        /*
         * TODO:
         * - Kommentare 
        */

        // Bilder laden
        Image wallImg;
        Image floorImg;
        Image startImg;
        Image exitImg;
        Image chestImg;
        Image trapImg;

        public Form1()
        {
            InitializeComponent();

            wallImg = Properties.Resources.wall;
            floorImg = Properties.Resources.floor;
            startImg = Properties.Resources.start;
            exitImg = Properties.Resources.exit;
            chestImg = Properties.Resources.chest;
            trapImg = Properties.Resources.trap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            mainScreen();
            hideButtons();
        }

        private void beendenBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void hideButtons()
        {
            beendenBtn.Visible = false;
            startBtn.Visible = false;
        }

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

            heightInput.Text = "40";
            widthInput.Text = "40";
            objectInput.Text = "5";
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            int height;
            int width;
            int objChance;

            bool heightOk = int.TryParse(heightInput.Text, out height);
            bool widthOk = int.TryParse(widthInput.Text, out width);
            bool objChanceOk = int.TryParse(objectInput.Text, out objChance);

            if (!objChanceOk || !heightOk || !widthOk || height < 10 || height > 200 || width < 10 || width > 200)
            {
                MessageBox.Show("Fehlerhafte Eingabe");
                return;
            }

            truhenCounter = 0;
            fallenCounter = 0;

            dungeonHeight = height;
            dungeonWidth = width;
            objectChance = objChance;

            dungeonPanel.Visible = true;

            dungeon = GenerateDungeon(dungeonHeight, dungeonWidth);
            dungeonPanel.Invalidate();

            dungeonFertig = true;
            exportBtn.Enabled = true;

            truhenLabel.Visible = true;
            fallenLabel.Visible = true;
            statistikenLabel.Visible = true;

            truhenLabel.Text = $"Truhen: {truhenCounter}";
            fallenLabel.Text = $"Fallen: {fallenCounter}";
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string standartPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dungeonFertig)
            {
                saveFileDialog.ShowDialog();
                string dateiname = saveFileDialog.FileName;

                if (Directory.Exists(standartPath))
                {
                    string pfad = Path.Combine(standartPath, dateiname + ".txt");
                    string gespeichertesDungeon = ArrayToText(dungeon);
                    File.WriteAllText(pfad, gespeichertesDungeon);
                    // MessageBox.Show("Dungeon wurde gespeichert!");
                }
            }
        }

        private void dungeonPanel_Paint(object sender, PaintEventArgs e)
        {
            if (dungeon == null) return;

            int tileSize = BerechneTileSize(dungeonWidth, dungeonHeight);

            for (int y = 0; y < dungeon.GetLength(0); y++)
            {
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
                        e.Graphics.DrawImage(img, x * tileSize, y * tileSize, tileSize, tileSize);
                }
            }
        }

        public static char[,] GenerateDungeon(int height, int width)
        {
            if (height % 2 == 0) height++;
            if (width % 2 == 0) width++;

            char[,] dungeon = new char[height, width];

            // Alles mit Wänden füllen
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    dungeon[y, x] = '#';

            // Startpunkt für Wege: immer ungerade Koordinaten
            int startX = 1;
            int startY = 1;
            if (startX % 2 == 0) startX++;
            if (startY % 2 == 0) startY++;

            // Wege generieren
            LabyrinthWege(dungeon, startY, startX);

            // Räume erzeugen
            int anzahl = (width * height) / 50;
            int raumAnzahl = Math.Min(50, anzahl);
            raumAnzahl += random.Next(-2, 3);
            raumAnzahl = Math.Max(2, raumAnzahl);

            for (int r = 0; r < raumAnzahl; r++)
            {
                int raumBreite = random.Next(2, 4);
                int raumHöhe = random.Next(2, 4);
                int rx = random.Next(1, width - raumBreite - 1);
                int ry = random.Next(1, height - raumHöhe - 1);

                for (int y = ry; y < ry + raumHöhe; y++)
                    for (int x = rx; x < rx + raumBreite; x++)
                        dungeon[y, x] = '.';
            }

            // Start zufällig auf einem ungeraden Feld
            int sx, sy;
            do
            {
                sx = random.Next(1, width - 1);
                sy = random.Next(1, height - 1);
            } while (dungeon[sy, sx] != '.');
            if (sx % 2 == 0) sx--;
            if (sy % 2 == 0) sy--;
            dungeon[sy, sx] = 'S';

            // Exit zufällig auf einem ungeraden Feld
            int ex, ey;
            do
            {
                ex = random.Next(1, width - 1);
                ey = random.Next(1, height - 1);
            } while (dungeon[ey, ex] != '.');
            if (ex % 2 == 0) ex--;
            if (ey % 2 == 0) ey--;
            dungeon[ey, ex] = 'E';

            // Truhen & Fallen
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
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
                }
            }

            return dungeon;
        }

        private static void LabyrinthWege(char[,] dungeon, int y, int x)
        {
            dungeon[y, x] = '.';

            int[][] dirs =
            {
                new int[]{ 0, 2 },
                new int[]{ 0,-2 },
                new int[]{ 2, 0 },
                new int[]{-2, 0 }
            };

            for (int i = 0; i < dirs.Length; i++)
            {
                int r = random.Next(dirs.Length);
                int[] temp = dirs[i];
                dirs[i] = dirs[r];
                dirs[r] = temp;
            }

            for (int i = 0; i < dirs.Length; i++)
            {
                int[] d = dirs[i];
                int nx = x + d[1];
                int ny = y + d[0];

                if (ny > 0 && ny < dungeon.GetLength(0) - 1 &&
                    nx > 0 && nx < dungeon.GetLength(1) - 1 &&
                    dungeon[ny, nx] == '#')
                {
                    dungeon[y + d[0] / 2, x + d[1] / 2] = '.';
                    LabyrinthWege(dungeon, ny, nx);
                }
            }
        }

        private static string ArrayToText(char[,] dungeon)
        {
            string dungeonText = "";

            for (int y = 0; y < dungeon.GetLength(0); y++)
            {
                for (int x = 0; x < dungeon.GetLength(1); x++)
                    dungeonText += dungeon[y, x];

                dungeonText += "\n";
            }

            return dungeonText;
        }


        private int BerechneTileSize(int dungeonWidth, int dungeonHeight)
        {
            if (dungeonWidth <= 0) dungeonWidth = 1;
            if (dungeonHeight <= 0) dungeonHeight = 1;

            int minTile = 3;
            int maxAllowedTile = 30; // nie größer als Panel zulässt

            // Dynamisches maxTile: kleineres Dungeon → größere Kacheln
            int maxTile = (int)Math.Ceiling(650.0 / Math.Max(dungeonWidth, dungeonHeight));
            // 600px ist Beispiel für Panelgröße, passt auf dein Panel an
            if (maxTile > maxAllowedTile) maxTile = maxAllowedTile;

            int maxMap = 40; // Bezugsgröße für Standardberechnung

            int sizeW = maxMap * maxTile / dungeonWidth;
            int sizeH = maxMap * maxTile / dungeonHeight;
            int tileSize = Math.Min(sizeW, sizeH);

            if (tileSize < minTile) tileSize = minTile;
            if (tileSize > maxAllowedTile) tileSize = maxAllowedTile;

            return tileSize;
        }

        private void heightLabel_Click(object sender, EventArgs e)
        {

        }

        private void widthLabel_Click(object sender, EventArgs e)
        {

        }

        private void heightInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void widthInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void objectLabel_click(object sender, EventArgs e)
        {

        }

        private void objectInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void dungeonAusgabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void dungeonName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dungeonNameLabel_Click(object sender, EventArgs e)
        {

        }


        private void pathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pathLabel_Click(object sender, EventArgs e)
        {

        }

        private void truhenLabel_Click(object sender, EventArgs e)
        {

        }

        private void fallenLabel_Click(object sender, EventArgs e)
        {

        }

    }
}