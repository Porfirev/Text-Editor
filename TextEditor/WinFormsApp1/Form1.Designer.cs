
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.pathFile = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.richPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Remove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveMessage = new System.Windows.Forms.Label();
            this.checkFile = new System.Windows.Forms.Label();
            this.AddFileConfirm = new System.Windows.Forms.Button();
            this.Unsave = new System.Windows.Forms.Button();
            this.readMe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.allFiles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неСохранятьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeFileWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funnyBallsToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlinedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikethroughToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интервалАвтоматическогоСохраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.выборToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.выборЦветТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.выборЦветаФонаФормыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorFormToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьФорматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жирныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зачёркнутыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подчёркнутыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richText
            // 
            this.richText.AcceptsTab = true;
            this.richText.BackColor = System.Drawing.SystemColors.Window;
            this.richText.ForeColor = System.Drawing.Color.Black;
            this.richText.Location = new System.Drawing.Point(0, 143);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(306, 187);
            this.richText.TabIndex = 1;
            this.richText.Text = "";
            this.richText.TextChanged += new System.EventHandler(this.RichText_TextChanged);
            // 
            // pathFile
            // 
            this.pathFile.Location = new System.Drawing.Point(0, 32);
            this.pathFile.Name = "pathFile";
            this.pathFile.Size = new System.Drawing.Size(306, 23);
            this.pathFile.TabIndex = 2;
            this.pathFile.TextChanged += new System.EventHandler(this.pathFile_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(0, 336);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // richPanel
            // 
            this.richPanel.Controls.Add(this.pictureBox);
            this.richPanel.Controls.Add(this.Remove);
            this.richPanel.Controls.Add(this.button1);
            this.richPanel.Controls.Add(this.saveMessage);
            this.richPanel.Controls.Add(this.checkFile);
            this.richPanel.Controls.Add(this.AddFileConfirm);
            this.richPanel.Controls.Add(this.Unsave);
            this.richPanel.Controls.Add(this.readMe);
            this.richPanel.Controls.Add(this.label3);
            this.richPanel.Controls.Add(this.allFiles);
            this.richPanel.Controls.Add(this.label2);
            this.richPanel.Controls.Add(this.label1);
            this.richPanel.Controls.Add(this.pathFile);
            this.richPanel.Controls.Add(this.Save);
            this.richPanel.Controls.Add(this.richText);
            this.richPanel.Location = new System.Drawing.Point(12, 27);
            this.richPanel.Name = "richPanel";
            this.richPanel.Size = new System.Drawing.Size(668, 468);
            this.richPanel.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(369, 143);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(212, 187);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(547, 31);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(100, 23);
            this.Remove.TabIndex = 14;
            this.Remove.Text = "Удалить";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Finish_Click);
            // 
            // saveMessage
            // 
            this.saveMessage.AutoSize = true;
            this.saveMessage.Location = new System.Drawing.Point(3, 387);
            this.saveMessage.Name = "saveMessage";
            this.saveMessage.Size = new System.Drawing.Size(0, 15);
            this.saveMessage.TabIndex = 12;
            // 
            // checkFile
            // 
            this.checkFile.AutoSize = true;
            this.checkFile.Location = new System.Drawing.Point(143, 80);
            this.checkFile.Name = "checkFile";
            this.checkFile.Size = new System.Drawing.Size(0, 15);
            this.checkFile.TabIndex = 11;
            // 
            // AddFileConfirm
            // 
            this.AddFileConfirm.Location = new System.Drawing.Point(3, 73);
            this.AddFileConfirm.Name = "AddFileConfirm";
            this.AddFileConfirm.Size = new System.Drawing.Size(107, 23);
            this.AddFileConfirm.TabIndex = 10;
            this.AddFileConfirm.Text = "Добавить файл";
            this.AddFileConfirm.UseVisualStyleBackColor = true;
            this.AddFileConfirm.Click += new System.EventHandler(this.AddFileConfirm_Click);
            // 
            // Unsave
            // 
            this.Unsave.Location = new System.Drawing.Point(199, 336);
            this.Unsave.Name = "Unsave";
            this.Unsave.Size = new System.Drawing.Size(107, 23);
            this.Unsave.TabIndex = 8;
            this.Unsave.Text = "Не сохранять";
            this.Unsave.UseVisualStyleBackColor = true;
            this.Unsave.Click += new System.EventHandler(this.Unsave_Click);
            // 
            // readMe
            // 
            this.readMe.Location = new System.Drawing.Point(540, 432);
            this.readMe.Name = "readMe";
            this.readMe.Size = new System.Drawing.Size(107, 24);
            this.readMe.TabIndex = 7;
            this.readMe.Text = "ReadMe";
            this.readMe.UseVisualStyleBackColor = true;
            this.readMe.Click += new System.EventHandler(this.ReadMe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Список добавленных файлов";
            // 
            // allFiles
            // 
            this.allFiles.FormattingEnabled = true;
            this.allFiles.Location = new System.Drawing.Point(360, 32);
            this.allFiles.Name = "allFiles";
            this.allFiles.Size = new System.Drawing.Size(121, 23);
            this.allFiles.TabIndex = 6;
            this.allFiles.SelectedIndexChanged += new System.EventHandler(this.AllFiles_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Содержание выбранного файла";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавить файл(Введите полный путь)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.неСохранятьToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.makeFileToolStripMenuItem,
            this.makeFileWindowToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.ToolTipText = "Ctrl+S";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save_Click);
            // 
            // неСохранятьToolStripMenuItem
            // 
            this.неСохранятьToolStripMenuItem.Name = "неСохранятьToolStripMenuItem";
            this.неСохранятьToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.неСохранятьToolStripMenuItem.Text = "Не сохранять";
            this.неСохранятьToolStripMenuItem.ToolTipText = "Ctrl+N";
            this.неСохранятьToolStripMenuItem.Click += new System.EventHandler(this.Unsave_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.ToolTipText = "Ctrl+Q";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.Finish_Click);
            // 
            // makeFileToolStripMenuItem
            // 
            this.makeFileToolStripMenuItem.Name = "makeFileToolStripMenuItem";
            this.makeFileToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.makeFileToolStripMenuItem.Text = "Создать файл в новой вкладке";
            this.makeFileToolStripMenuItem.ToolTipText = "Ctrl+O";
            this.makeFileToolStripMenuItem.Click += new System.EventHandler(this.MakeFileToolStripMenuItem_Click);
            // 
            // makeFileWindowToolStripMenuItem
            // 
            this.makeFileWindowToolStripMenuItem.Name = "makeFileWindowToolStripMenuItem";
            this.makeFileWindowToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.makeFileWindowToolStripMenuItem.Text = "Создать файл в новом окне";
            this.makeFileWindowToolStripMenuItem.ToolTipText = "Ctrl+P";
            this.makeFileWindowToolStripMenuItem.Click += new System.EventHandler(this.MakeFileWindowToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eggToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // eggToolStripMenuItem
            // 
            this.eggToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funnyBallsToolStripMenuItem});
            this.eggToolStripMenuItem.Name = "eggToolStripMenuItem";
            this.eggToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.eggToolStripMenuItem.Text = "Смешарики";
            // 
            // funnyBallsToolStripMenuItem
            // 
            this.funnyBallsToolStripMenuItem.Name = "funnyBallsToolStripMenuItem";
            this.funnyBallsToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.funnyBallsToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.FunnyBallsToolStripMenuItem_SelectedIndexChanged);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.italicToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.underlinedToolStripMenuItem,
            this.strikethroughToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.italicToolStripMenuItem.Text = "Курсив";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.ItalicToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.boldToolStripMenuItem.Text = "Жирный";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.BoldToolStripMenuItem_Click);
            // 
            // underlinedToolStripMenuItem
            // 
            this.underlinedToolStripMenuItem.Name = "underlinedToolStripMenuItem";
            this.underlinedToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.underlinedToolStripMenuItem.Text = "Подчёркнутый";
            this.underlinedToolStripMenuItem.Click += new System.EventHandler(this.UnderlinedToolStripMenuItem_Click);
            // 
            // strikethroughToolStripMenuItem
            // 
            this.strikethroughToolStripMenuItem.Name = "strikethroughToolStripMenuItem";
            this.strikethroughToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.strikethroughToolStripMenuItem.Text = "Зачёркнутый";
            this.strikethroughToolStripMenuItem.Click += new System.EventHandler(this.StrikethroughToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.defaultToolStripMenuItem.Text = "Обычный";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.DefaultToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.интервалАвтоматическогоСохраненияToolStripMenuItem,
            this.выборToolStripMenuItem,
            this.выборЦветТекстаToolStripMenuItem,
            this.выборЦветаФонаФормыToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // интервалАвтоматическогоСохраненияToolStripMenuItem
            // 
            this.интервалАвтоматическогоСохраненияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeToolStripMenuItem});
            this.интервалАвтоматическогоСохраненияToolStripMenuItem.Name = "интервалАвтоматическогоСохраненияToolStripMenuItem";
            this.интервалАвтоматическогоСохраненияToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.интервалАвтоматическогоСохраненияToolStripMenuItem.Text = "Интервал автоматического сохранения";
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.timeToolStripMenuItem.Text = "10 секунд";
            this.timeToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.TimeToolStripMenuItem_SelectedIndexChanged);
            // 
            // выборToolStripMenuItem
            // 
            this.выборToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backColorToolStripMenuItem});
            this.выборToolStripMenuItem.Name = "выборToolStripMenuItem";
            this.выборToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.выборToolStripMenuItem.Text = "Выбор цвет фона";
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.backColorToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.BackColourToolStripMenuItem_SelectedIndexChanged);
            // 
            // выборЦветТекстаToolStripMenuItem
            // 
            this.выборЦветТекстаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreColorToolStripMenuItem});
            this.выборЦветТекстаToolStripMenuItem.Name = "выборЦветТекстаToolStripMenuItem";
            this.выборЦветТекстаToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.выборЦветТекстаToolStripMenuItem.Text = "Выбор цвет текста";
            // 
            // foreColorToolStripMenuItem
            // 
            this.foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            this.foreColorToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.foreColorToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.ForeColourToollStripMenuItem_SelectedIndexChanged);
            // 
            // выборЦветаФонаФормыToolStripMenuItem
            // 
            this.выборЦветаФонаФормыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backColorFormToolStripMenuItem});
            this.выборЦветаФонаФормыToolStripMenuItem.Name = "выборЦветаФонаФормыToolStripMenuItem";
            this.выборЦветаФонаФормыToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.выборЦветаФонаФормыToolStripMenuItem.Text = "Выбор цвета фона формы";
            // 
            // backColorFormToolStripMenuItem
            // 
            this.backColorFormToolStripMenuItem.Name = "backColorFormToolStripMenuItem";
            this.backColorFormToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.backColorFormToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.BackColourFormToolStripMenuItem_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.выбратьФорматToolStripMenuItem,
            this.сutToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(168, 114);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.copyToolStripMenuItem.Text = "Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pasteToolStripMenuItem.Text = "Вставить";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.selectAllToolStripMenuItem.Text = "Выделить все";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // выбратьФорматToolStripMenuItem
            // 
            this.выбратьФорматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.курсивToolStripMenuItem,
            this.жирныйToolStripMenuItem,
            this.зачёркнутыйToolStripMenuItem,
            this.подчёркнутыйToolStripMenuItem,
            this.обычныйToolStripMenuItem});
            this.выбратьФорматToolStripMenuItem.Name = "выбратьФорматToolStripMenuItem";
            this.выбратьФорматToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.выбратьФорматToolStripMenuItem.Text = "Выбрать формат";
            // 
            // курсивToolStripMenuItem
            // 
            this.курсивToolStripMenuItem.Name = "курсивToolStripMenuItem";
            this.курсивToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.курсивToolStripMenuItem.Text = "Курсив";
            this.курсивToolStripMenuItem.Click += new System.EventHandler(this.ItalicToolStripMenuItem_Click);
            // 
            // жирныйToolStripMenuItem
            // 
            this.жирныйToolStripMenuItem.Name = "жирныйToolStripMenuItem";
            this.жирныйToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.жирныйToolStripMenuItem.Text = "Жирный";
            this.жирныйToolStripMenuItem.Click += new System.EventHandler(this.BoldToolStripMenuItem_Click);
            // 
            // зачёркнутыйToolStripMenuItem
            // 
            this.зачёркнутыйToolStripMenuItem.Name = "зачёркнутыйToolStripMenuItem";
            this.зачёркнутыйToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.зачёркнутыйToolStripMenuItem.Text = "Зачёркнутый";
            this.зачёркнутыйToolStripMenuItem.Click += new System.EventHandler(this.StrikethroughToolStripMenuItem_Click);
            // 
            // подчёркнутыйToolStripMenuItem
            // 
            this.подчёркнутыйToolStripMenuItem.Name = "подчёркнутыйToolStripMenuItem";
            this.подчёркнутыйToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.подчёркнутыйToolStripMenuItem.Text = "Подчёркнутый";
            this.подчёркнутыйToolStripMenuItem.Click += new System.EventHandler(this.UnderlinedToolStripMenuItem_Click);
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.обычныйToolStripMenuItem.Text = "Обычный";
            this.обычныйToolStripMenuItem.Click += new System.EventHandler(this.DefaultToolStripMenuItem_Click);
            // 
            // сutToolStripMenuItem
            // 
            this.сutToolStripMenuItem.Name = "сutToolStripMenuItem";
            this.сutToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.сutToolStripMenuItem.Text = "Вырезать";
            this.сutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 496);
            this.Controls.Add(this.richPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TextEditor(1)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.richPanel.ResumeLayout(false);
            this.richPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.TextBox pathFile;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Panel richPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox allFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Unsave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неСохранятьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.Button AddFileConfirm;
        private System.Windows.Forms.Label checkFile;
        private System.Windows.Forms.Label saveMessage;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интервалАвтоматическогоСохраненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox timeToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem выборToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox backColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборЦветТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox foreColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlinedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikethroughToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeFileWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eggToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripComboBox funnyBallsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьФорматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жирныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зачёркнутыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подчёркнутыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сutToolStripMenuItem;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem выборЦветаФонаФормыToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox backColorFormToolStripMenuItem;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button readMe;
    }
}

