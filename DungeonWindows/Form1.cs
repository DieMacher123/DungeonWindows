using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonWindows
{
    public partial class Form1 : Form
    {

        /* TODO:
            - Kommentare
        */

        private static Random random = new Random();

        private static bool dungeonFertig = false;
        private static int objectChance = 5;
        private static int dungeonHeight = 0;
        private static int dungeonWidth = 0;
        private static int fallenCounter = 0;
        private static int truhenCounter = 0;
        char[,] dungeon = new char[0, 0];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //öffnet den start
            mainScreen();
            hideButtons();
        }

        private void dokumentationBtn_Click(object sender, EventArgs e)
        {
            //öffnet die dokumentation
            hideButtons();
            beendenBtn.Visible = true;
            startBtn.Visible = true;

            DokumentationInBox(); // Ausgabe in RichTextBox
            dokumentationBox.Visible = true;
        }

        private void beendenBtn_Click(object sender, EventArgs e)
        {
            //verlassen des dungeons
            Environment.Exit(0);
        }

        private void hideButtons()
        {
            // versteckt die buttons
            DokumentationBtn.Visible = false;
            beendenBtn.Visible = false;
            startBtn.Visible = false;

        }

        private void mainScreen()
        {
            //Der main screen mit feldern
            dokumentationBox.Visible = false;
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
            //überprüfung der Eingaben
            bool heightOk = int.TryParse(heightInput.Text, out height);
            bool widthOk = int.TryParse(widthInput.Text, out width);
            bool objChanceOk = int.TryParse(objectInput.Text, out objChance);

            if (!objChanceOk || !heightOk || !widthOk || height < 10 || height > 40 || width < 10 || width > 40 || objChance == 0 || objChance > 100)
            {
                MessageBox.Show("Fehlerhafte eingabe");
                return;
            }

            truhenCounter = 0;
            fallenCounter = 0;

            dungeonHeight = height;
            dungeonWidth = width;
            objectChance = objChance;

            dungeonAusgabe.Visible = true;

            dungeon = GenerateDungeon(dungeonHeight, dungeonWidth);
            FarbigeAusgabe(dungeon);
            dungeonFertig = true;

            truhenLabel.Visible = true;
            fallenLabel.Visible = true;
            statistikenLabel.Visible = true;

            truhenLabel.Text = $"Truhen: {truhenCounter}";
            fallenLabel.Text = $"Fallen: {fallenCounter}";


        }

        private void exportBtn_Click(object sender, EventArgs e)
        {

            string standartPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Ungültige Zeichen prüfen

            if (dungeonFertig)
            {
                saveFileDialog.ShowDialog();
                string dateiname = saveFileDialog.FileName;
 
                if (Directory.Exists(standartPath))
                {
                    string pfad = Path.Combine(standartPath, dateiname);

                    string gespeichertesDungeon = ArrayToText(dungeon);


                    File.WriteAllText(pfad, gespeichertesDungeon);
                    MessageBox.Show("Dungeon wurde gespeichert!");

                }
                else
                {
                    MessageBox.Show("Pfad existiert nicht!");
                    return;
                }
            }
        }

        void DokuInfo(char symbol, Color farbe, string text)
        {
            dokumentationBox.SelectionColor = farbe;
            dokumentationBox.AppendText(symbol + " ");
            dokumentationBox.SelectionColor = Color.Black;
            dokumentationBox.AppendText("= " + text + "\n");
        }

        private void DokumentationInBox()
        {

            dokumentationBox.Clear(); // RichTextBox leeren

            dokumentationBox.AppendText("                  DUNGEON DOKUMENTATION                  \n\n");

            dokumentationBox.AppendText("In diesem Dungeon können folgende Elemente erscheinen:\n\n");

            DokuInfo('#', Color.White, "Wand – blockiert den Weg.");
            DokuInfo('.', Color.DarkGray, "Weg – begehbares Feld.");
            DokuInfo('S', Color.Green, "Startpunkt – hier startet es.");
            DokuInfo('E', Color.Red, "Ausgang – Ziel des Dungeons.");
            DokuInfo('T', Color.Yellow, "Truhe – enthält Belohnungen.");
            DokuInfo('F', Color.DarkRed, "Falle – verursacht Schaden oder Nachteile.");

            dokumentationBox.AppendText("\nHinweis:\n");
            dokumentationBox.SelectionColor = Color.Cyan;
            dokumentationBox.AppendText("Räume und Wege werden zufällig generiert. Truhen und Fallen haben eine Chance von 5% pro Wegfeld.\n\n");
            dokumentationBox.SelectionColor = Color.Magenta;
            dokumentationBox.AppendText("Viel Spaß beim Erkunden des Dungeons!\n\n");
            dokumentationBox.SelectionColor = Color.Black;
        }

        // Dungeon Generator: Räume, Wege, Start, Ende, Objekte
        public static char[,] GenerateDungeon(int height, int width)
        {
            // Größe anpassen (ungerade Werte um doppelte wänden entgegenzuwirken)
            if (height % 2 == 0) height++;
            if (width % 2 == 0) width++;

            // Dungeon mit Wänden füllen
            char[,] dungeon = new char[height, width];
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    dungeon[y, x] = '#';

            // Räume erzeugen
            int anzahl = (width * height) / 50;
            int raumAnzahl = Math.Min(20, anzahl);
            raumAnzahl += random.Next(-2, 3);
            raumAnzahl = Math.Max(3, raumAnzahl);

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

            // Labyrinth erzeugen
            LabyrinthWege(dungeon, 1, 1);

            // Startpunkt setzen
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

            // Truhen und Fallen verteilen
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    if (dungeon[y, x] == '.' && random.Next(100) < objectChance)
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

            return dungeon;
        }

        // Rekursiver Maze Generator (Depth-First-Search algorythmus)
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

            // Richtungen mischen
            for (int i = 0; i < dirs.Length; i++)
            {
                int r = random.Next(dirs.Length);
                int[] temp = dirs[i];
                dirs[i] = dirs[r];
                dirs[r] = temp;
            }

            // Punkte verbinden
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

        public void FarbigeAusgabe(char[,] dungeon)
        {
            dungeonAusgabe.Clear();

            for (int y = 0; y < dungeon.GetLength(0); y++)
            {
                for (int x = 0; x < dungeon.GetLength(1); x++)
                {
                    char c = dungeon[y, x];

                    switch (c)
                    {
                        case '.': dungeonAusgabe.SelectionColor = Color.DarkGray; break;
                        case '#': dungeonAusgabe.SelectionColor = Color.White; break;
                        case 'S': dungeonAusgabe.SelectionColor = Color.LawnGreen; break;
                        case 'E': dungeonAusgabe.SelectionColor = Color.Red; break;
                        case 'T': dungeonAusgabe.SelectionColor = Color.Yellow; break;
                        case 'F': dungeonAusgabe.SelectionColor = Color.DarkRed; break;
                        default: dungeonAusgabe.SelectionColor = Color.Black; break;
                    }
                    dungeonAusgabe.AppendText(c.ToString());
                }

                dungeonAusgabe.AppendText("\n");
            }
        }

        private static void DokuInfo(char symbol, ConsoleColor farbe, string text)
        {
            Console.ForegroundColor = farbe;
            Console.Write(symbol + " ");
            Console.ResetColor();
            Console.WriteLine("= " + text);
        }

        // Dokumentation des Dungeons (Erklärung aller Symbole)
        public static void Dokumentation()
        {
            Console.Clear();
            Console.WriteLine("--------------- DUNGEON DOKUMENTATION ---------------\n");
            Console.WriteLine("In diesem Dungeon können folgende Elemente erscheinen:\n");

            DokuInfo('#', ConsoleColor.White, "Wand – blockiert den Weg.");
            DokuInfo('.', ConsoleColor.DarkGray, "Weg – begehbares Feld.");
            DokuInfo('S', ConsoleColor.Green, "Startpunkt – hier startet es.");
            DokuInfo('E', ConsoleColor.Red, "Ausgang – Ziel des Dungeons.");
            DokuInfo('T', ConsoleColor.Yellow, "Truhe – enthält Belohnungen.");
            DokuInfo('F', ConsoleColor.DarkRed, "Falle – verursacht Schaden oder Nachteile.");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hinweis:");
            Console.ResetColor();
            Console.WriteLine("Räume und Wege werden zufällig generiert. Truhen und Fallen haben eine Chance von 5% pro Wegfeld.\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Viel Spaß beim Erkunden des Dungeons!");
            Console.ResetColor();
            Console.WriteLine("\n-----------------------------------------------------\n");

            Console.WriteLine("1. Spiel Starten\n2. Hauptmenü");
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

        private void dokumentationBox_TextChanged(object sender, EventArgs e)
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

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
