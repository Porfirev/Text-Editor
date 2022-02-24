using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        static string[] colours = { "Жёлтый", "Зелёный", "Чёрный", "Белый", "Красный", "Серый", "Синий", "Оранжевый" };
        static Color[] progcColours = { Color.Yellow, Color.Green, Color.Black, Color.White, Color.Red, Color.Gray, Color.Blue, Color.Orange };
        static string[] pathFunnyBalls = {@"FunnyBalls\Barash.png", @"FunnyBalls\Yozhik.jpg", @"FunnyBalls\Krosh.jpg", @"FunnyBalls\Nusha.jpg", @"FunnyBalls\Kar-Karich.jpg",
        @"FunnyBalls\Losash.jpg", @"FunnyBalls\Kopatich.jpg", @"FunnyBalls\Pin.jpg", @"FunnyBalls\Sovuniya.jpg", @"FunnyBalls\notebookHSE.jpg"};
        static string[] funnyBalls = { "Бараш", "Ёжик", "Крош", "Нюша", "Кар-Карыч", "Лосяш", "Копатыч", "Пин", "Совунья", "Не хочу смешариков" };
        string buffer;
        Color start;

        public Form1()
        {
            start = SystemColors.Control;
            InitializeComponent();
        }

        /// <summary>
        /// Событие которое при создании окна присваивает начальное значение элементам.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] last = File.ReadAllLines("last.txt");
            buffer = "";
            allFiles.DropDownStyle = ComboBoxStyle.DropDownList;
            timeToolStripMenuItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            backColorToolStripMenuItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allFiles.Items.Clear();
            allFiles.Enabled = true;
            this.checkFile.Text = "";
            this.saveMessage.Text = "";
            this.timeToolStripMenuItem.Items.Add("10 секунд");
            this.timeToolStripMenuItem.Items.Add("15 секунд");
            this.timeToolStripMenuItem.Items.Add("30 секунд");
            this.timeToolStripMenuItem.Items.Add("1 минута");
            this.timeToolStripMenuItem.Items.Add("2 минуты");
            this.timeToolStripMenuItem.Items.Add("5 минут");
            this.timeToolStripMenuItem.Items.Add("15 минут");
            this.timeToolStripMenuItem.Items.Add("30 минут");
            this.timeToolStripMenuItem.Items.Add("1 час");
            this.timeToolStripMenuItem.Items.Add("2 часа");
            this.timeToolStripMenuItem.Items.Add("Никогда");
            this.timer1.Enabled = false;
            this.timeToolStripMenuItem.SelectedIndex = int.Parse(last[0]);
            foreach(var item in colours)
            {
                this.backColorToolStripMenuItem.Items.Add(item);
                this.foreColorToolStripMenuItem.Items.Add(item);
                this.backColorFormToolStripMenuItem.Items.Add(item);
            }
            this.backColorFormToolStripMenuItem.Items.Add("Базовый");
            foreach (var item in funnyBalls)
            {
                this.funnyBallsToolStripMenuItem.Items.Add(item);
            }
            pathFile.Text = "";
            this.foreColorToolStripMenuItem.SelectedIndex = int.Parse(last[1]);
            this.backColorToolStripMenuItem.SelectedIndex = int.Parse(last[2]);
            this.backColorFormToolStripMenuItem.SelectedIndex = int.Parse(last[3]);
            this.funnyBallsToolStripMenuItem.SelectedIndex = int.Parse(last[4]);
            this.FunnyBallsToolStripMenuItem_SelectedIndexChanged(sender, e);
            for (int i = 5; i < last.Length; ++i)
            {
                allFiles.Items.Add(last[i]);
            }
            richText.Text = "";
            richText.SelectionFont = new Font(richText.Font, FontStyle.Regular);
            this.richText.ContextMenuStrip = this.contextMenuStrip2;
        }

        /// <summary>
        /// Перегрузка горячих клавишю.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="keys"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {
                case Keys.Control | Keys.N:
                    this.Unsave_Click();
                    return true;
                case Keys.Control | Keys.S:
                    this.Save_Click();
                    return true;
                case Keys.Control | Keys.Q:
                    this.Finish_Click();
                    return true;
                case Keys.Control | Keys.O:
                    this.MakeFileToolStripMenuItem_Click();
                    return true;
                case Keys.Control | Keys.P:
                    this.MakeFileWindowToolStripMenuItem_Click();
                    return true;
            }
            return base.ProcessCmdKey(ref message, keys);
        }

        /// <summary>
        /// Cобытие для кнопки закрыть, закрывающее программу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Finish_Click(object sender = null, EventArgs e = null)
        {
            this.Close();
        }

        /// <summary>
        /// Cобытие для кнопки сохранить, сохраняющие настоящий файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender=null, EventArgs e=null)
        {
            if(this.allFiles.Items.Count == 0)
            {
                return;
            }
            try
            {
                string path = this.allFiles.SelectedItem.ToString();
                int i = path.Length - 1;
                while (path[i] != '.')
                {
                    i--;
                }
                string domen = "";
                for (; i < path.Length; ++i)
                {
                    domen += path[i];
                }
                if (domen == ".txt")
                    File.WriteAllText(path, this.richText.Text);
                else if (domen == ".rtf")
                    this.richText.SaveFile(path);
                allFiles.Enabled = true;
            }
            catch
            {
            }
            this.checkFile.Text = "";
            this.saveMessage.Text = "";
        }

        /// <summary>
        /// Событие отвечающее за выбор файла из добавленных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.allFiles.Items.Count == 0)
            {
                return;
            }
            try
            {
                string[] stime = this.timeToolStripMenuItem.SelectedItem.ToString().Split(' ');
                if (stime.Length == 2) 
                {
                    this.timer1.Start();
                }
                string path = this.allFiles.SelectedItem.ToString();
                int i = path.Length - 1;
                while (path[i] != '.')
                {
                    i--;
                }
                string domen = "";
                for (; i < path.Length; ++i)
                {
                    domen += path[i];
                }
                if (domen == ".txt")
                    this.richText.Text = File.ReadAllText(path);
                else if (domen == ".rtf")
                    this.richText.LoadFile(path);
                else
                    this.richText.Text = "";
            }
            catch(Exception er)
            {
                this.richText.Text = er.Message;
            }
            allFiles.Enabled = true;
            this.checkFile.Text = "";
            this.saveMessage.Text = "";
        }

        /// <summary>
        /// Событие, которое происходит если текст в поле, для вывода файла изменился.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RichText_TextChanged(object sender, EventArgs e)
        {
            this.checkFile.Text = "";
            if (this.richText.Text != "")
            {
                this.saveMessage.Text = "Вы не сохранили этот файл, поэтому не можете перейти к другому.\n Если вы хотите сохранить этот файл то нажмите \"Сохранить\", иначе \"Не сохранять\"";
                allFiles.Enabled = false;
            }
        }

        /// <summary>
        /// Cобытие для кнопки сохранить, сохраняющие настоящий файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Unsave_Click(object sender = null, EventArgs e = null)
        {
            allFiles.Enabled = true;
            this.checkFile.Text = "";
            this.saveMessage.Text = "";
        }

        /// <summary>
        /// Cобытие для кнопки добавить файл, добавляющие файл в список.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFileConfirm_Click(object sender = null, EventArgs e = null)
        {
            string path = this.pathFile.Text.Trim('"');
            try
            {
                string check = File.ReadAllText(path);
                bool was = false;
                for (int i = 0; i < this.allFiles.Items.Count; ++i)
                {
                    was = was || this.allFiles.Items[i].ToString() == path;
                }
                if (!was)
                {
                    this.allFiles.Items.Add(path);
                    this.checkFile.Text = "Файл успешно добавлен!!!";
                }
                else
                {
                    MessageBox.Show("Этот файл уже добавлен");
                    this.checkFile.Text = "";
                }
                allFiles.Enabled = true;
            }
            catch
            {
                try
                {
                    bool was = false;
                    for (int i = 0; i < this.allFiles.Items.Count; ++i)
                    {
                        was = was || this.allFiles.Items[i].ToString() == path;
                    }
                    if (!was)
                    {
                        int i = path.Length - 1;
                        while (path[i] != '.')
                        {
                            i--;
                        }
                        string domen = "";
                        for (; i < path.Length; ++i)
                        {
                            domen += path[i];
                        }
                        if(domen == ".txt")
                        {
                            File.WriteAllText(path, "");
                        }
                        else if(domen == ".rtf")
                        {
                            this.richText.SaveFile(path);
                        }
                        else
                        {
                            throw new ArgumentException("Wrong domen");
                        }
                        this.checkFile.Text = "Такого файла не существует, поэтому программа создала, этот файл с пустым текстом";
                        this.allFiles.Items.Add(path);
                    }
                    else
                    {
                        MessageBox.Show("Этот файл уже добавлен");
                        this.checkFile.Text = "";
                    }
                    allFiles.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Добавить файл невозможно, возможно вы указали неверный путь. Или у этого файла не то расширение");
                    this.checkFile.Text = "";
                }
            }
        }

        /// <summary>
        /// Событие которое, происходит когда меняеться текст в поле для ввода пути к файлу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pathFile_TextChanged(object sender, EventArgs e)
        {
            this.checkFile.Text = "";
            Save.Enabled = true;
            Unsave.Enabled = true;
        }

        /// <summary>
        /// Событие на реакцию таймера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Save_Click();
        }

        /// <summary>
        /// Событие реагирующее на изменение, выбора интервала автоматического сохранения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeToolStripMenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] stime = this.timeToolStripMenuItem.SelectedItem.ToString().Split(' ');
            if (stime.Length == 2)
            {
                int time;
                int.TryParse(stime[0], out int rtime);
                if (stime[1] == "секунд")
                {
                    time = rtime * 1000;
                }
                else if (stime[1].Substring(0, 5) == "минут")
                {
                    time = rtime * 1000 * 60;
                }
                else
                {
                    time = rtime * 1000 * 60 * 60;
                }
                this.timer1.Interval = time;
                this.timer1.Start();
            }
        }

        /// <summary>
        /// Событие реагирующее на изменение, выбора цвета текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForeColourToollStripMenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richText.ForeColor = progcColours[this.foreColorToolStripMenuItem.SelectedIndex];
        }

        /// <summary>
        /// Событие реагирующее на изменение, выбора цвета поля для текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackColourToolStripMenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richText.BackColor = progcColours[this.backColorToolStripMenuItem.SelectedIndex];
        }

        /// <summary>
        /// Событие для курсива.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richText.SelectionFont != null)
                richText.SelectionFont = new Font(richText.Font, FontStyle.Italic | richText.SelectionFont.Style);
            else
                richText.SelectionFont = new Font(richText.Font, FontStyle.Italic);
        }

        /// <summary>
        /// Событие для жирного текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
                richText.SelectionFont = new Font(richText.Font, FontStyle.Bold | richText.SelectionFont.Style);
            else
                richText.SelectionFont = new Font(richText.Font, FontStyle.Bold);
        }

        /// <summary>
        /// Событие для подчёркнутого текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnderlinedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
                richText.SelectionFont = new Font(richText.Font, FontStyle.Underline | richText.SelectionFont.Style);
            else
                richText.SelectionFont = new Font(richText.Font, FontStyle.Underline);
        }

        /// <summary>
        /// Событие для зачёркнутого текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StrikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
                richText.SelectionFont = new Font(richText.Font, FontStyle.Strikeout | richText.SelectionFont.Style);
            else
                richText.SelectionFont = new Font(richText.Font, FontStyle.Strikeout);
        }

        /// <summary>
        /// Событие для обычного текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.SelectionFont = new Font(richText.Font, FontStyle.Regular);
        }

        /// <summary>
        /// Событие для создания файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeFileToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {
            this.AddFileConfirm_Click();
        }

        /// <summary>
        /// Событие для создания файла в новом окне.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeFileWindowToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {
            Form1 newForm = new Form1();
            newForm.Visible = true;
            int i = 0;
            while (i < this.Text.Length && this.Text[i] != '(')
            {
                ++i;
            }
            newForm.Text = this.Text.Substring(0, i + 1);
            int start = i;
            while(i < this.Text.Length && this.Text[i] != ')')
            {
                ++i;
            }
            int.TryParse(this.Text.Substring(start + 1, i - start - 1), out int num);
            num++;
            newForm.Text += num.ToString();
            newForm.Text += ")";
            newForm.pathFile.Text = this.pathFile.Text;
            newForm.MakeFileToolStripMenuItem_Click();
        }


        /// <summary>
        /// Cобытие для кнопки копировать.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buffer = richText.SelectedText;
        }

        /// <summary>
        /// Cобытие для кнопки вставить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.SelectedText = buffer;
        }

        /// <summary>
        /// Cобытие для выделения всего текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.SelectionStart = 0;
            richText.SelectionLength = this.richText.Text.Length;
        }

        /// <summary>
        /// Cобытие для кнопки вырезать.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buffer = richText.SelectedText;
            richText.SelectedText = "";
        }

        /// <summary>
        /// Событие закрывающее форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allFiles.Enabled)
            {
                MessageBox.Show("Вы не сохранили этот файл, поэтому не можете закрыть окно.\n Если вы хотите сохранить этот файл то нажмите \"Сохранить\", иначе \"Не сохранять\"");
                e.Cancel = true;
            }
            else
            {
                string path = "last.txt";
                File.WriteAllText(path, timeToolStripMenuItem.SelectedIndex.ToString() + "\n");
                File.AppendAllText(path, foreColorToolStripMenuItem.SelectedIndex.ToString() + "\n");
                File.AppendAllText(path, backColorToolStripMenuItem.SelectedIndex.ToString() + "\n");
                File.AppendAllText(path, backColorFormToolStripMenuItem.SelectedIndex.ToString() + "\n");
                File.AppendAllText(path, funnyBallsToolStripMenuItem.SelectedIndex.ToString() + "\n");
                foreach(var item in allFiles.Items)
                {
                    File.AppendAllText(path, item + "\n");
                }
                e.Cancel = false;
            }
            this.checkFile.Text = "";
        }

        /// <summary>
        /// Событие реагирующее на изменение, выбора цвета поля для формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackColourFormToolStripMenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.backColorFormToolStripMenuItem.SelectedIndex != this.backColorFormToolStripMenuItem.Items.Count - 1)
                BackColor = progcColours[this.backColorFormToolStripMenuItem.SelectedIndex];
            else
                BackColor = start;
        }

        /// <summary>
        /// Cобытие для кнопки удалить файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                allFiles.Items.Remove(allFiles.SelectedItem);
                richText.Text = "";
            }
            catch { }
        }

        /// <summary>
        /// Событие выводящие ReadMe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText("README.txt"));
        }

        /// <summary>
        /// Событие реагирующее на изменение выбора смешарика.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FunnyBallsToolStripMenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.funnyBallsToolStripMenuItem.SelectedIndex != 9)
            {
                this.pictureBox.Image = Image.FromFile(pathFunnyBalls[this.funnyBallsToolStripMenuItem.SelectedIndex]);
                this.pictureBox.Visible = true;
            }
            else
                this.pictureBox.Visible = false;
        }
    }
}
