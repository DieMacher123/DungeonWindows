using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
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

        private Stopwatch stopwatch = new Stopwatch();

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

        private void startBtn_Click(object sender, EventArgs e)
        {
            mainScreen();
            hideButtons();
        }

        private void beendenBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void beendenBtn2_Click(object sender, EventArgs e)
        {
            beendenBtn_Click(sender, e);
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
            helpBtn.Visible = true;
            beendenBtn2.Visible = true;

            heightInput.Text = "40";
            widthInput.Text = "40";
            objectInput.Text = "5";
        }

        private void hideButtons()
        {
            beendenBtn.Visible = false;
            startBtn.Visible = false;
        }

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

            timerLabel.Text = $"Zeit: 0 ms";

            stopwatch.Restart();

            dungeon = GenerateDungeon(dungeonHeight, dungeonWidth);

            truhenLabel.Text = $"Truhen: {truhenCounter}";
            fallenLabel.Text = $"Fallen: {fallenCounter}";

            dungeonPanel.Visible = true;
            dungeonPanel.Invalidate();

            dungeonFertig = true;
            exportBtn.Enabled = true;

            statistikenLabel.Visible = true;
            truhenLabel.Visible = true;
            fallenLabel.Visible = true;
            timerLabel.Visible = true;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (!dungeonFertig) return;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pfad = saveFileDialog.FileName;

                if (Path.GetExtension(pfad) != ".txt")
                    pfad += ".txt";

                string gespeichertesDungeon = ArrayToText(dungeon);
                File.WriteAllText(pfad, gespeichertesDungeon);
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

            stopwatch.Stop();
            timerLabel.Text = $"Zeit: {stopwatch.ElapsedMilliseconds} ms";
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
            }
            while (dungeon[sy, sx] != '.');
            dungeon[sy, sx] = 'S';

            // Endpunkt setzen (mit Mindestabstand)
            int ex, ey, abstand;
            do
            {
                ex = random.Next(1, width - 1);
                ey = random.Next(1, height - 1);
                abstand = Math.Abs(ex - sx) + Math.Abs(ey - sy);
            }
            while (dungeon[ey, ex] != '.' || abstand < 8);
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
            int maxSize = Math.Max(dungeonWidth, dungeonHeight);

            if (maxSize < 10) maxSize = 10;
            if (maxSize > 40) maxSize = 40;

            double t = (maxSize - 10) / 30.0; // 0 bis 1
            int tileSize = (int)(30 - t * (30 - 17));
            tileSize = Math.Max(17, Math.Min(30, tileSize));

            return tileSize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void statistikenLabel_Click(object sender, EventArgs e)
        {

        }

        private void timerLabel_Click(object sender, EventArgs e)
        {

        }

        private void fallenLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void truhenLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void truheIconLabel_Click(object sender, EventArgs e)
        {

        }

        private void truhenIcon_Click(object sender, EventArgs e)
        {

        }

        private void falleIconLabel_Click(object sender, EventArgs e)
        {

        }

        private void bodenIconLabel_Click(object sender, EventArgs e)
        {

        }

        private void wandIcon_Click(object sender, EventArgs e)
        {

        }

        private void wandIconLabel_Click(object sender, EventArgs e)
        {

        }

        private void endeIconLabel_Click(object sender, EventArgs e)
        {

        }

        private void startIconLabel_Click(object sender, EventArgs e)
        {

        }

        private void fallenIcon_Click(object sender, EventArgs e)
        {

        }

        private void startIcon_Click(object sender, EventArgs e)
        {

        }

        private void bodenIcon_Click(object sender, EventArgs e)
        {

        }

        private void endeIcon_Click(object sender, EventArgs e)
        {

        }

        private void dokumentationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}