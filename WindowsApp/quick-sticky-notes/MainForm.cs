﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace quick_sticky_notes
{
	public partial class MainForm : Form
	{
        private FirebaseManager fm;
        private NoteManager noteManager;
        private bool quitApp = false;
        private AboutForm aboutForm;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style = NativeMethodsManager.WS_SYSMENU;
                cp.ClassStyle |= NativeMethodsManager.CS_DROPSHADOW;
                return cp;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            this.Hide();

            noteManager = new NoteManager();
            noteManager.NoteAdded += NoteManager_NoteAdded;

            fm = new FirebaseManager();
            fm.UpdateNote += Fm_UpdateNote;
            fm.SignStatusChanged += Fm_SignStatusChanged;
            fm.LoadUserFromDisk();
            StateManager.InitToolStripMenuItem(tsmsState, (o, e) => {
                var tsmsItem = o as ToolStripMenuItem;
                if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
                {
                    Note note = notesListBox.SelectedItem as Note;

                    note.Hide();
                    note.ChangeState(tsmsItem.Text);

                    notesListBox.Invalidate();
                }
            });
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.Image = Properties.Resources.white_close;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.Image = Properties.Resources.black_close;
        }

        private void Fm_SignStatusChanged(object sender, EventArgs e)
        {
            //syncBtn.Visible = fm.IsLoggedIn();
        }

        private void Fm_UpdateNote(object sender, UpdateNoteEventArgs e)
        {
            noteManager.UpdateNote(e.Data);
            notesListBox.Invalidate();
        }

        private void NoteManager_NoteAdded(object sender, NoteAddedEventArgs e)
        {
            notesListBox.Invoke((MethodInvoker)(() => {
                if (noteManager.currentFolder == e.Note.folderName)
                {
                    notesListBox.Items.Add(e.Note);
                }
            }));

            e.Note.ContentChanged += Note_ContentChanged;
            e.Note.TitleChanged += Note_TitleChanged;
            e.Note.VisibleChanged += Note_VisibleChanged;
            e.Note.PositionChanged += Note_PositionChanged;
            e.Note.PerformNewNote += Note_PerformNewNote;
            e.Note.PerformMoveToTrash += Note_PerformMoveToTrash;
            e.Note.PerformSync += Note_PerformSync;
            e.Note.ShowNotesList += Note_ShowNotesList;
            e.Note.ColorChanged += Note_ColorChanged;
            e.Note.FolderChanged += Note_FolderChanged;
            e.Note.StateChanged += Note_StateChanged;
            if (e.Note.visible && e.Note.folderName != noteManager.trashFolderId)
            {
                e.Note.Show();
            }
        }

        private void Note_StateChanged(object sender, EventArgs e)
        {
            noteManager.SaveNoteToDisk(sender as Note);
        }

        private void Note_FolderChanged(object sender, EventArgs e)
        {
            notesListBox.Invoke((MethodInvoker)(() => {
                notesListBox.Items.Clear();
                List<Note> ln = noteManager.SearchFor();
                for (int i = 0; i < ln.Count; i++)
                {
                    notesListBox.Items.Add(ln[i]);
                }

                noteManager.SaveNoteToDisk(sender as Note);
            }));
        }

        private void Note_ColorChanged(object sender, ColorChangedEventArgs e)
        {
            noteManager.SaveNoteToDisk(sender as Note);
        }

        private void Note_ShowNotesList(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
        }

        private void Note_PerformSync(object sender, EventArgs e)
        {
            if (fm.IsLoggedIn())
            {
                fm.SyncNote(sender as Note);
            }
        }

        private void Note_PerformMoveToTrash(object sender, EventArgs e)
        {
            Note note = sender as Note;

            note.ChangeFolder(noteManager.trashFolderId);

            notesListBox.Invalidate();
        }

        private void Note_PerformNewNote(object sender, PerformNewNoteEventArgs e)
        {
            noteManager.NewNote(fm.GenerateUniqueID());
        }

        private void Note_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            noteManager.SaveNoteToDisk(sender as Note);
        }

        private void Note_VisibleChanged(object sender, VisibleChangedEventArgs e)
        {
            notesListBox.Invalidate();
            noteManager.SaveNoteToDisk(sender as Note);
        }

        private void newNoteBtn_Click(object sender, EventArgs e)
        {
            noteManager.NewNote(fm.GenerateUniqueID());
        }

        private void Note_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            for (int i = 0; i < notesListBox.Items.Count; i++)
            {
                if (notesListBox.Items[i] as Note == sender)
                {
                    notesListBox.Items[i] = sender;
                }
            }
            noteManager.SaveNoteToDisk(sender as Note);
        }

        private void Note_ContentChanged(object sender, ContentChangedEventArgs e)
        {
            for (int i = 0; i < notesListBox.Items.Count; i++)
            {
                if (notesListBox.Items[i] as Note == sender)
                {
                    notesListBox.Items[i] = sender;
                }
            }
            noteManager.SaveNoteToDisk(sender as Note);
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            if (fm.IsLoggedIn())
            {
                fm.ShowProfileForm();
            }
            else
            {
                fm.ShowLoginForm();
            }
        }

        private void notesListBox_DoubleClick_1(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;

                if (note.folderName == noteManager.trashFolderId)
                {
                    note.ChangeFolder(noteManager.noFolderId);
                    note.Show();
                    allNotesBtn.PerformClick();
                }
                else
                {
                    if (note.visible)
                    {
                        note.Focus();
                    }
                    else
                    {
                        note.Show();
                    }
                }
            }
        }

        private void notesListBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (!searchTextBox.Focused)
                {
                    int index = notesListBox.IndexFromPoint(e.Location);

                    if (noteManager.currentFolder == noteManager.trashFolderId)
                    {
                        if (index != ListBox.NoMatches)
                        {
                            notesListBox.SelectedIndex = index;
                            trashListItemContext.Show(Cursor.Position);
                        }
                        else
                        {
                            trashListEmptyContext.Show(Cursor.Position);
                        }
                    }
                    else
                    {
                        if (index != ListBox.NoMatches)
                        {
                            notesListBox.SelectedIndex = index;
                            notesListItemContext.Show(Cursor.Position);
                        }
                        else
                        {
                            notesListEmptyContext.Show(Cursor.Position);
                        }
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            noteManager.LoadNotesFromDisk();
            
            if (fm.IsLoggedIn())
            {
                //fm.LoadNotesFromServer();

                fm.AddObserversForServer();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;

                note.Hide();
                note.ChangeFolder(noteManager.trashFolderId);

                notesListBox.Invalidate();
            }
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteManager.NewNote(fm.GenerateUniqueID());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!quitApp)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quitApp = true;
            this.Close();
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.BringToFront();
            }
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor.Current = Cursors.SizeAll;
                NativeMethodsManager.ReleaseCapture();
                NativeMethodsManager.SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            this.titlePanel_MouseDown(sender, e);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                if (note.visible)
                {
                    note.Focus();
                }
                else
                {
                    note.Show();
                }
            }
        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteManager.NewNote(fm.GenerateUniqueID());
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            searchTextBox.ForeColor = Color.Black;
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            searchTextBox.Text = "Search your notes...";
            searchTextBox.ForeColor = Color.FromArgb(100, 100, 100);
        }

        private void notesListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                Note note = notesListBox.Items[e.Index] as Note;

                Brush darkBrush = new SolidBrush(ColorManager.GetDarkColor(note.colorStr));
                Brush middleBrush = new SolidBrush(ColorManager.GetMiddleColor(note.colorStr));
                Brush noteBrush = new SolidBrush(ColorManager.GetNoteColor(note.colorStr));
                Brush backBrush = new SolidBrush(notesListBox.BackColor);

                e.Graphics.FillRectangle(darkBrush, new RectangleF(
                    e.Bounds.X + 9,
                    e.Bounds.Y + 9,
                    e.Bounds.Width - 18,
                    8
                ));
                e.Graphics.FillRectangle(noteBrush, new RectangleF(
                    e.Bounds.X + 9,
                    e.Bounds.Y + 17,
                    e.Bounds.Width - 18,
                    e.Bounds.Height - 17
                ));

                if (note.title.Length > 8)
                {
                    e.Graphics.DrawString(note.title.Substring(0, 8)+"..", e.Font, darkBrush, e.Bounds.X + 16, e.Bounds.Y + 21);
                }
                else
                {
                    e.Graphics.DrawString(note.title, e.Font, darkBrush, e.Bounds.X + 16, e.Bounds.Y + 21);
                }
                e.Graphics.DrawString(note.dateCreated.ToString("yyyy-MM-dd HH"), e.Font, darkBrush, e.Bounds.X + 150, e.Bounds.Y + 21);
                var color = StateManager.GetStateColor(note.state);
                
                e.Graphics.FillEllipse(new SolidBrush(color), new RectangleF(e.Bounds.Right-50, e.Bounds.Y+21,20,20));
                if (note.contentText.Length > 100)
                {
                    e.Graphics.DrawString(Regex.Replace(note.contentText.Substring(0, 100), @"\t|\n|\r", " "), e.Font, middleBrush, e.Bounds.X + 16, e.Bounds.Y + 39);
                }
                else
                {
                    e.Graphics.DrawString(Regex.Replace(note.contentText, @"\t|\n|\r", " "), e.Font, middleBrush, e.Bounds.X + 16, e.Bounds.Y + 39);
                }

                e.Graphics.FillRectangle(backBrush, new RectangleF(
                    e.Bounds.X + e.Bounds.Width - 9,
                    e.Bounds.Y,
                    9,
                    e.Bounds.Height
                ));

                // right side gradient
                var rc = new Rectangle(
                    e.Bounds.X + e.Bounds.Width - 39,
                    e.Bounds.Y + 17,
                    20,
                    e.Bounds.Height - 17
                );
                using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    rc,
                    Color.FromArgb(0, ColorManager.GetNoteColor(note.colorStr)),
                    Color.FromArgb(255, ColorManager.GetNoteColor(note.colorStr)),
                    0f
                ))
                {
                    e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                    e.Graphics.FillRectangle(brush, rc);
                }

                e.Graphics.FillRectangle(noteBrush, new RectangleF(
                    e.Bounds.X + e.Bounds.Width - 21,
                    e.Bounds.Y + 17,
                    12,
                    e.Bounds.Height - 17
                ));

                // bottom right corner
                if (note.visible)
                {
                    PointF[] outerNoteTriangle =
                    {
                            new PointF(e.Bounds.X + e.Bounds.Width - 9, e.Bounds.Y + e.Bounds.Height - 12),
                            new PointF(e.Bounds.X + e.Bounds.Width - 21, e.Bounds.Y + e.Bounds.Height),
                            new PointF(e.Bounds.X + e.Bounds.Width - 9, e.Bounds.Y + e.Bounds.Height)
                    };
                    e.Graphics.FillPolygon(backBrush, outerNoteTriangle);

                    PointF[] innerNoteTriangle =
                        {
                            new PointF(e.Bounds.X + e.Bounds.Width - 9, e.Bounds.Y + e.Bounds.Height - 12),
                            new PointF(e.Bounds.X + e.Bounds.Width - 21, e.Bounds.Y + e.Bounds.Height),
                            new PointF(e.Bounds.X + e.Bounds.Width - 21, e.Bounds.Y + e.Bounds.Height - 12)
                    };
                    e.Graphics.FillPolygon(middleBrush, innerNoteTriangle);
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length > 0 && searchTextBox.Text != "Search your notes...")
            {
                notesListBox.Items.Clear();
                List<Note> ln = noteManager.SearchFor(searchTextBox.Text);
                for (int i = 0; i < ln.Count; i++)
                {
                    notesListBox.Items.Add(ln[i]);
                }
            }
            else
            {
                notesListBox.Items.Clear();
                List<Note> ln = noteManager.SearchFor();
                for (int i = 0; i < ln.Count; i++)
                {
                    notesListBox.Items.Add(ln[i]);
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.Shift)
                {
                    if (e.KeyCode == Keys.P)
                    {
                        profileBtn.PerformClick();
                    }
                    else if (e.KeyCode == Keys.T)
                    {
                        emptyTrashToolStripMenuItem.PerformClick();
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.N)
                    {
                        newNoteBtn.PerformClick();
                    }
                    else if (e.KeyCode == Keys.U)
                    {
                        allNotesBtn.PerformClick();
                    }
                    else if (e.KeyCode == Keys.T)
                    {
                        trashBtn.PerformClick();
                    }
                    else if (e.KeyCode == Keys.P)
                    {
                        pinnedNotesBtn.PerformClick();
                    }
                    else if (e.KeyCode == Keys.F)
                    {
                        searchTextBox.Focus();
                    }
                    else if (e.KeyCode == Keys.Oemcomma)
                    {
                        settingsBtn.Focus();
                    }
                }
            }
            else
            {
                if (e.KeyCode == Keys.F1)
                {
                    aboutBtn.PerformClick();
                }
            }
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                notesListBox.Focus();
            }
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.SetColor("yellow");
                notesListBox.Invalidate();
            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.SetColor("green");
                notesListBox.Invalidate();
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.SetColor("blue");
                notesListBox.Invalidate();
            }
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.SetColor("pink");
                notesListBox.Invalidate();
            }
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.SetColor("purple");
                notesListBox.Invalidate();
            }
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;
                note.SetColor("white");
                notesListBox.Invalidate();
            }
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            notesListBox.Focus();

            titlePanel.BackColor = ColorManager.UIColor3;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            titlePanel.BackColor = ColorManager.UIColor4;
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            if (aboutForm == null || aboutForm.IsDisposed)
            {
                aboutForm = new AboutForm();
                if (aboutForm.ShowDialog() == DialogResult.Cancel)
                {
                    aboutForm.Dispose();
                }
            }
        }

        private void logoPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            titlePanel_MouseDown(sender, e);
        }

        private void allNotesBtn_Click(object sender, EventArgs e)
        {
            if (noteManager.currentFolder != noteManager.noFolderId)
            {
                noteManager.currentFolder = noteManager.noFolderId;

                notesListBox.Items.Clear();
                List<Note> ln = noteManager.SearchFor();
                for (int i = 0; i < ln.Count; i++)
                {
                    notesListBox.Items.Add(ln[i]);
                }

                allNotesBtn.BackColor = ColorManager.UIColor5;
                trashBtn.BackColor = ColorManager.UIColor3;
            }
        }

        private void trashBtn_Click(object sender, EventArgs e)
        {
            if (noteManager.currentFolder != noteManager.trashFolderId)
            {
                noteManager.currentFolder = noteManager.trashFolderId;

                notesListBox.Items.Clear();
                List<Note> ln = noteManager.SearchFor();
                for (int i = 0; i < ln.Count; i++)
                {
                    notesListBox.Items.Add(ln[i]);
                }

                allNotesBtn.BackColor = ColorManager.UIColor3;
                trashBtn.BackColor = ColorManager.UIColor5;
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;

                note.ChangeFolder(noteManager.noFolderId);

                notesListBox.Invalidate();
            }
        }

        private void emptyTrashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trashBtn.PerformClick();

            if (notesListBox.Items.Count > 0)
            {
                for (int i = 0; i < notesListBox.Items.Count; i++)
                {
                    Note note = notesListBox.Items[i] as Note;

                    if (notesListBox.Items.Contains(note))
                    {
                        notesListBox.Items.Remove(note);
                    }

                    noteManager.RemoveNote(note);
                    fm.RemoveNote(note.uniqueId);

                    i--;
                }

                notesListBox.Invalidate();
            }
        }

        private void deleteForewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListBox.Items.Count > 0 && notesListBox.SelectedItem != null)
            {
                Note note = notesListBox.SelectedItem as Note;

                if (notesListBox.Items.Contains(note))
                {
                    notesListBox.Items.Remove(note);
                }

                noteManager.RemoveNote(note);
                fm.RemoveNote(note.uniqueId);

                notesListBox.Invalidate();
            }
        }

        private void btOpt_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btOpt.Right,btOpt.Bottom);
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
