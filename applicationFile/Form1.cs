
using System;
using System.IO;
using System.Windows.Forms;

namespace applicationFile
{
    public partial class Form1 : Form
    {
        string path1 = string.Empty;
        string path2 = string.Empty;

        public Form1()
        {
            InitializeComponent();
            getAllDrives();
            this.WindowState = FormWindowState.Maximized;
        }

        // Get all drives on the system
        private void getAllDrives()
        {
            DriveInfo[] d = DriveInfo.GetDrives();
            foreach (DriveInfo drive in d)
            {
                listBox1.Items.Add(drive.Name);
                listBox2.Items.Add(drive.Name);
            }
        }

        // Get all directories in the specified path and populate the list box
        private void getAllDirects(string d, ListBox lis)
        {
            DirectoryInfo drived = new DirectoryInfo(@$"{d}");
            if (drived.Exists)
            {
                DirectoryInfo[] dires = drived.GetDirectories();
                foreach (DirectoryInfo file in dires)
                {
                    lis.Items.Add(file.Name);
                }
            }
        }

        // Get all files in the specified path and populate the list box
        private void getAllFiles(string d, ListBox lis)
        {
            DirectoryInfo files = new DirectoryInfo(@$"{d}");
            if (files.Exists)
            {
                FileInfo[] allFiles = files.GetFiles();
                foreach (FileInfo file in allFiles)
                {
                    lis.Items.Add(file.Name);
                }
            }
        }

        // Handle selection change in listBox1 (left list box)
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                path1 = Path.Combine(path1, listBox1.SelectedItem.ToString());
                textBox1.Text = path1;
                listBox1.Items.Clear();

                getAllDirects(path1, listBox1);
                getAllFiles(path1, listBox1);
            }
        }

        // Handle selection change in listBox2 (right list box)
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                path2 = Path.Combine(path2, listBox2.SelectedItem.ToString());
                textBox2.Text = path2;
                listBox2.Items.Clear();

                getAllDirects(path2, listBox2);
                getAllFiles(path2, listBox2);
            }
        }

        // Copy button logic
        private void copyButtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(path1))
            {
                File.Copy(path1, Path.Combine(path2, Path.GetFileName(path1)), true);
                MessageBox.Show("File copied successfully!");
            }
            else if (Directory.Exists(path1))
            {
                CopyDirectory(path1, Path.Combine(path2, new DirectoryInfo(path1).Name));
                MessageBox.Show("Directory copied successfully!");
            }
            else
            {
                MessageBox.Show("Invalid source path!");
            }
        }

        // Move selected item from right to left
        private void moveToLeft_Click(object sender, EventArgs e)
        {
            MoveItem(path2, path1);
        }

        // Move selected item from left to right
        private void moveToRight_Click(object sender, EventArgs e)
        {
            MoveItem(path1, path2);
        }

        // Helper method to move files or directories
        private void MoveItem(string sourcePath, string destinationPath)
        {
            try
            {
                if (File.Exists(sourcePath))
                {
                    string destinationFile = Path.Combine(destinationPath, Path.GetFileName(sourcePath));
                    File.Move(sourcePath, destinationFile);
                    MessageBox.Show("File moved successfully!");
                }
                else if (Directory.Exists(sourcePath))
                {
                    string destinationDir = Path.Combine(destinationPath, new DirectoryInfo(sourcePath).Name);
                    Directory.Move(sourcePath, destinationDir);
                    MessageBox.Show("Directory moved successfully!");
                }
                else
                {
                    MessageBox.Show("Invalid source path!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Helper method to copy directories recursively
        private void CopyDirectory(string sourceDir, string destinationDir)
        {
            if (!Directory.Exists(destinationDir))
            {
                Directory.CreateDirectory(destinationDir);
            }

            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destinationDir, Path.GetFileName(file));
                File.Copy(file, destFile, true);
            }

            foreach (string dir in Directory.GetDirectories(sourceDir))
            {
                string destDir = Path.Combine(destinationDir, new DirectoryInfo(dir).Name);
                CopyDirectory(dir, destDir);
            }
        }

        // Back button logic (to navigate up one level)
        private void backButtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(path1))
            {
                path1 = Directory.GetParent(path1)?.FullName ?? string.Empty;
                textBox1.Text = path1;
                listBox1.Items.Clear();
                getAllDirects(path1, listBox1);
                getAllFiles(path1, listBox1);
            }

            if (!string.IsNullOrEmpty(path2))
            {
                path2 = Directory.GetParent(path2)?.FullName ?? string.Empty;
                textBox2.Text = path2;
                listBox2.Items.Clear();
                getAllDirects(path2, listBox2);
                getAllFiles(path2, listBox2);
            }
        }
    }
}