﻿namespace BottleOpener
{
    partial class bottleopener
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bottleopener));
            this.launchbutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolstripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandPromptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.textboxInstructions = new System.Windows.Forms.TextBox();
            this.textboxDirectory = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonCommandPrompt = new System.Windows.Forms.Button();
            this.textboxTools = new System.Windows.Forms.TextBox();
            this.buttonREGedit = new System.Windows.Forms.Button();
            this.buttonDiskManagement = new System.Windows.Forms.Button();
            this.buttonPowershellPrompt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.controlPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.createGodModeFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessibilityOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewHardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internetPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joystickPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modemPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mousePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multimediaPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printersFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionalSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scannersAndCamerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // launchbutton
            // 
            this.launchbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.launchbutton.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchbutton.Location = new System.Drawing.Point(458, 206);
            this.launchbutton.Name = "launchbutton";
            this.launchbutton.Size = new System.Drawing.Size(231, 81);
            this.launchbutton.TabIndex = 0;
            this.launchbutton.Text = "Launch";
            this.launchbutton.UseVisualStyleBackColor = true;
            this.launchbutton.Click += new System.EventHandler(this.launchbutton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripFile,
            this.controlPanelToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolstripAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolstripFile
            // 
            this.toolstripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripExit});
            this.toolstripFile.Name = "toolstripFile";
            this.toolstripFile.Size = new System.Drawing.Size(37, 20);
            this.toolstripFile.Text = "File";
            // 
            // toolstripExit
            // 
            this.toolstripExit.Name = "toolstripExit";
            this.toolstripExit.Size = new System.Drawing.Size(152, 22);
            this.toolstripExit.Text = "Exit";
            this.toolstripExit.Click += new System.EventHandler(this.toolstripExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchToolStripMenuItem,
            this.commandPromptToolStripMenuItem,
            this.createGodModeFolderToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // launchToolStripMenuItem
            // 
            this.launchToolStripMenuItem.Name = "launchToolStripMenuItem";
            this.launchToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.launchToolStripMenuItem.Text = "Launch Button";
            this.launchToolStripMenuItem.Click += new System.EventHandler(this.launchToolStripMenuItem_Click);
            // 
            // commandPromptToolStripMenuItem
            // 
            this.commandPromptToolStripMenuItem.Name = "commandPromptToolStripMenuItem";
            this.commandPromptToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.commandPromptToolStripMenuItem.Text = "Tools";
            this.commandPromptToolStripMenuItem.Click += new System.EventHandler(this.commandPromptToolStripMenuItem_Click);
            // 
            // toolstripAbout
            // 
            this.toolstripAbout.Name = "toolstripAbout";
            this.toolstripAbout.Size = new System.Drawing.Size(52, 20);
            this.toolstripAbout.Text = "About";
            this.toolstripAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textboxInstructions
            // 
            this.textboxInstructions.BackColor = System.Drawing.SystemColors.Control;
            this.textboxInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxInstructions.Cursor = System.Windows.Forms.Cursors.Default;
            this.textboxInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxInstructions.Location = new System.Drawing.Point(12, 27);
            this.textboxInstructions.Multiline = true;
            this.textboxInstructions.Name = "textboxInstructions";
            this.textboxInstructions.ReadOnly = true;
            this.textboxInstructions.Size = new System.Drawing.Size(327, 39);
            this.textboxInstructions.TabIndex = 2;
            this.textboxInstructions.Text = "Enter executable\'s directory:";
            this.textboxInstructions.TextChanged += new System.EventHandler(this.textboxInstructions_TextChanged);
            // 
            // textboxDirectory
            // 
            this.textboxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDirectory.Location = new System.Drawing.Point(58, 72);
            this.textboxDirectory.Name = "textboxDirectory";
            this.textboxDirectory.Size = new System.Drawing.Size(580, 31);
            this.textboxDirectory.TabIndex = 3;
            this.textboxDirectory.TextChanged += new System.EventHandler(this.textboxDirectory_TextChanged);
            this.textboxDirectory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxDirectory_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonCommandPrompt
            // 
            this.buttonCommandPrompt.Location = new System.Drawing.Point(12, 151);
            this.buttonCommandPrompt.Name = "buttonCommandPrompt";
            this.buttonCommandPrompt.Size = new System.Drawing.Size(75, 38);
            this.buttonCommandPrompt.TabIndex = 5;
            this.buttonCommandPrompt.Text = "Command Prompt";
            this.buttonCommandPrompt.UseVisualStyleBackColor = true;
            this.buttonCommandPrompt.Click += new System.EventHandler(this.buttonCommandPrompt_Click);
            // 
            // textboxTools
            // 
            this.textboxTools.BackColor = System.Drawing.SystemColors.Control;
            this.textboxTools.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxTools.Cursor = System.Windows.Forms.Cursors.Default;
            this.textboxTools.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxTools.Location = new System.Drawing.Point(58, 109);
            this.textboxTools.Multiline = true;
            this.textboxTools.Name = "textboxTools";
            this.textboxTools.ReadOnly = true;
            this.textboxTools.Size = new System.Drawing.Size(83, 36);
            this.textboxTools.TabIndex = 6;
            this.textboxTools.Text = "Tools";
            this.textboxTools.TextChanged += new System.EventHandler(this.textboxTools_TextChanged);
            // 
            // buttonREGedit
            // 
            this.buttonREGedit.Location = new System.Drawing.Point(12, 195);
            this.buttonREGedit.Name = "buttonREGedit";
            this.buttonREGedit.Size = new System.Drawing.Size(75, 39);
            this.buttonREGedit.TabIndex = 7;
            this.buttonREGedit.Text = "Registry Editor";
            this.buttonREGedit.UseVisualStyleBackColor = true;
            this.buttonREGedit.Click += new System.EventHandler(this.buttonREGedit_Click);
            // 
            // buttonDiskManagement
            // 
            this.buttonDiskManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiskManagement.Location = new System.Drawing.Point(93, 151);
            this.buttonDiskManagement.Name = "buttonDiskManagement";
            this.buttonDiskManagement.Size = new System.Drawing.Size(84, 38);
            this.buttonDiskManagement.TabIndex = 10;
            this.buttonDiskManagement.Text = "Disk Management";
            this.buttonDiskManagement.UseVisualStyleBackColor = true;
            this.buttonDiskManagement.Click += new System.EventHandler(this.buttonDiskManagement_Click);
            // 
            // buttonPowershellPrompt
            // 
            this.buttonPowershellPrompt.Location = new System.Drawing.Point(93, 240);
            this.buttonPowershellPrompt.Name = "buttonPowershellPrompt";
            this.buttonPowershellPrompt.Size = new System.Drawing.Size(84, 37);
            this.buttonPowershellPrompt.TabIndex = 16;
            this.buttonPowershellPrompt.Text = "Task Manager";
            this.buttonPowershellPrompt.UseVisualStyleBackColor = true;
            this.buttonPowershellPrompt.Click += new System.EventHandler(this.buttonPowershellPrompt_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "System Informations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(581, 175);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 25);
            this.button5.TabIndex = 18;
            this.button5.Text = "Control Panel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(93, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "Device Manager";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // controlPanelToolStripMenuItem
            // 
            this.controlPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessibilityOptionsToolStripMenuItem,
            this.addNewHardwareToolStripMenuItem,
            this.addRemoveProgramsToolStripMenuItem,
            this.dateTimeToolStripMenuItem,
            this.pToolStripMenuItem,
            this.fontsFolderToolStripMenuItem,
            this.internetPropertiesToolStripMenuItem,
            this.joystickPropertiesToolStripMenuItem,
            this.modemPropertiesToolStripMenuItem,
            this.mousePropertiesToolStripMenuItem,
            this.multimediaPropertiesToolStripMenuItem,
            this.printersFolderToolStripMenuItem,
            this.regionalSettingsToolStripMenuItem,
            this.scannersAndCamerasToolStripMenuItem,
            this.soundPropertiesToolStripMenuItem,
            this.systemPropertiesToolStripMenuItem});
            this.controlPanelToolStripMenuItem.Name = "controlPanelToolStripMenuItem";
            this.controlPanelToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.controlPanelToolStripMenuItem.Text = "Control Panel";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(324, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 28);
            this.button3.TabIndex = 20;
            this.button3.Text = "Create GodMode Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // createGodModeFolderToolStripMenuItem
            // 
            this.createGodModeFolderToolStripMenuItem.Name = "createGodModeFolderToolStripMenuItem";
            this.createGodModeFolderToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createGodModeFolderToolStripMenuItem.Text = "GodMode Folder";
            this.createGodModeFolderToolStripMenuItem.Click += new System.EventHandler(this.createGodModeFolderToolStripMenuItem_Click);
            // 
            // accessibilityOptionsToolStripMenuItem
            // 
            this.accessibilityOptionsToolStripMenuItem.Name = "accessibilityOptionsToolStripMenuItem";
            this.accessibilityOptionsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.accessibilityOptionsToolStripMenuItem.Text = "Accessibility Options";
            this.accessibilityOptionsToolStripMenuItem.Click += new System.EventHandler(this.accessibilityOptionsToolStripMenuItem_Click);
            // 
            // addNewHardwareToolStripMenuItem
            // 
            this.addNewHardwareToolStripMenuItem.Name = "addNewHardwareToolStripMenuItem";
            this.addNewHardwareToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.addNewHardwareToolStripMenuItem.Text = "Add New Hardware";
            this.addNewHardwareToolStripMenuItem.Click += new System.EventHandler(this.addNewHardwareToolStripMenuItem_Click);
            // 
            // addRemoveProgramsToolStripMenuItem
            // 
            this.addRemoveProgramsToolStripMenuItem.Name = "addRemoveProgramsToolStripMenuItem";
            this.addRemoveProgramsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.addRemoveProgramsToolStripMenuItem.Text = "Add/Remove Programs";
            this.addRemoveProgramsToolStripMenuItem.Click += new System.EventHandler(this.addRemoveProgramsToolStripMenuItem_Click);
            // 
            // dateTimeToolStripMenuItem
            // 
            this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            this.dateTimeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.dateTimeToolStripMenuItem.Text = "Date/Time Properties";
            this.dateTimeToolStripMenuItem.Click += new System.EventHandler(this.dateTimeToolStripMenuItem_Click);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.pToolStripMenuItem.Text = "Display Properties";
            this.pToolStripMenuItem.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // fontsFolderToolStripMenuItem
            // 
            this.fontsFolderToolStripMenuItem.Name = "fontsFolderToolStripMenuItem";
            this.fontsFolderToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.fontsFolderToolStripMenuItem.Text = "Fonts Folder";
            this.fontsFolderToolStripMenuItem.Click += new System.EventHandler(this.fontsFolderToolStripMenuItem_Click);
            // 
            // internetPropertiesToolStripMenuItem
            // 
            this.internetPropertiesToolStripMenuItem.Name = "internetPropertiesToolStripMenuItem";
            this.internetPropertiesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.internetPropertiesToolStripMenuItem.Text = "Internet Properties";
            this.internetPropertiesToolStripMenuItem.Click += new System.EventHandler(this.internetPropertiesToolStripMenuItem_Click);
            // 
            // joystickPropertiesToolStripMenuItem
            // 
            this.joystickPropertiesToolStripMenuItem.Name = "joystickPropertiesToolStripMenuItem";
            this.joystickPropertiesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.joystickPropertiesToolStripMenuItem.Text = "Joystick Properties";
            this.joystickPropertiesToolStripMenuItem.Click += new System.EventHandler(this.joystickPropertiesToolStripMenuItem_Click);
            // 
            // modemPropertiesToolStripMenuItem
            // 
            this.modemPropertiesToolStripMenuItem.Name = "modemPropertiesToolStripMenuItem";
            this.modemPropertiesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.modemPropertiesToolStripMenuItem.Text = "Modem Properties";
            this.modemPropertiesToolStripMenuItem.Click += new System.EventHandler(this.modemPropertiesToolStripMenuItem_Click);
            // 
            // mousePropertiesToolStripMenuItem
            // 
            this.mousePropertiesToolStripMenuItem.Name = "mousePropertiesToolStripMenuItem";
            this.mousePropertiesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.mousePropertiesToolStripMenuItem.Text = "Mouse Properties";
            this.mousePropertiesToolStripMenuItem.Click += new System.EventHandler(this.mousePropertiesToolStripMenuItem_Click);
            // 
            // multimediaPropertiesToolStripMenuItem
            // 
            this.multimediaPropertiesToolStripMenuItem.Name = "multimediaPropertiesToolStripMenuItem";
            this.multimediaPropertiesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.multimediaPropertiesToolStripMenuItem.Text = "Multimedia Properties";
            this.multimediaPropertiesToolStripMenuItem.Click += new System.EventHandler(this.multimediaPropertiesToolStripMenuItem_Click);
            // 
            // printersFolderToolStripMenuItem
            // 
            this.printersFolderToolStripMenuItem.Name = "printersFolderToolStripMenuItem";
            this.printersFolderToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.printersFolderToolStripMenuItem.Text = "Printers Folder";
            this.printersFolderToolStripMenuItem.Click += new System.EventHandler(this.printersFolderToolStripMenuItem_Click);
            // 
            // regionalSettingsToolStripMenuItem
            // 
            this.regionalSettingsToolStripMenuItem.Name = "regionalSettingsToolStripMenuItem";
            this.regionalSettingsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.regionalSettingsToolStripMenuItem.Text = "Regional Settings";
            this.regionalSettingsToolStripMenuItem.Click += new System.EventHandler(this.regionalSettingsToolStripMenuItem_Click);
            // 
            // scannersAndCamerasToolStripMenuItem
            // 
            this.scannersAndCamerasToolStripMenuItem.Name = "scannersAndCamerasToolStripMenuItem";
            this.scannersAndCamerasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.scannersAndCamerasToolStripMenuItem.Text = "Scanners and Cameras";
            this.scannersAndCamerasToolStripMenuItem.Click += new System.EventHandler(this.scannersAndCamerasToolStripMenuItem_Click);
            // 
            // soundPropertiesToolStripMenuItem
            // 
            this.soundPropertiesToolStripMenuItem.Name = "soundPropertiesToolStripMenuItem";
            this.soundPropertiesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.soundPropertiesToolStripMenuItem.Text = "Sound Properties";
            this.soundPropertiesToolStripMenuItem.Click += new System.EventHandler(this.soundPropertiesToolStripMenuItem_Click);
            // 
            // systemPropertiesToolStripMenuItem
            // 
            this.systemPropertiesToolStripMenuItem.Name = "systemPropertiesToolStripMenuItem";
            this.systemPropertiesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.systemPropertiesToolStripMenuItem.Text = "System Properties";
            this.systemPropertiesToolStripMenuItem.Click += new System.EventHandler(this.systemPropertiesToolStripMenuItem_Click);
            // 
            // bottleopener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 299);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPowershellPrompt);
            this.Controls.Add(this.buttonDiskManagement);
            this.Controls.Add(this.buttonREGedit);
            this.Controls.Add(this.textboxTools);
            this.Controls.Add(this.buttonCommandPrompt);
            this.Controls.Add(this.textboxDirectory);
            this.Controls.Add(this.textboxInstructions);
            this.Controls.Add(this.launchbutton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "bottleopener";
            this.Text = "BottleOpener";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launchbutton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolstripFile;
        private System.Windows.Forms.ToolStripMenuItem toolstripExit;
        private System.Windows.Forms.ToolStripMenuItem toolstripAbout;
        private System.Windows.Forms.TextBox textboxInstructions;
        private System.Windows.Forms.TextBox textboxDirectory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonCommandPrompt;
        private System.Windows.Forms.TextBox textboxTools;
        private System.Windows.Forms.Button buttonREGedit;
        private System.Windows.Forms.Button buttonDiskManagement;
        private System.Windows.Forms.Button buttonPowershellPrompt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandPromptToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem controlPanelToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem createGodModeFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessibilityOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewHardwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveProgramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontsFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internetPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joystickPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modemPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mousePropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multimediaPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printersFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionalSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scannersAndCamerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemPropertiesToolStripMenuItem;
    }
}

