﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;


namespace Text_Reading_for_Visually_Impaired
{
    public partial class second_Page : Form
    {
        Boolean paused = false;
        Boolean stopped = false;
        SpeechSynthesizer synth = new SpeechSynthesizer();
        string Text_To_Read = "";
        public second_Page()
        {
            InitializeComponent();
            synth = new SpeechSynthesizer();
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;
            synth.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(speak_in_progress);
        }

        private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            object filename = e.Data.GetData("FileDrop");
            if (filename != null)
            {
                var list = filename as string[];
                if (list != null && !string.IsNullOrWhiteSpace(list[0]))
                {
                    richTextBox1.Clear();
                    richTextBox1.LoadFile(list[0], RichTextBoxStreamType.PlainText);
                    //string[] lines = System.IO.File.ReadAllLines(e.Data.);
                    /*foreach (String line in lines)
                    {
                        richTextBox1.AppendText(line);
                    }*/

                }

            }

        }
        private void speak_in_progress(object sender, SpeakProgressEventArgs e)
        {
            if(stopped)
            {
                
            }
            richTextBox1.HideSelection = false;
            int textposition = e.CharacterPosition;
            richTextBox1.Find(e.Text,textposition, RichTextBoxFinds.WholeWord);

            //richTextBox1.Select(0,textposition);
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            //synth = new SpeechSynthesizer();
           // synth.SetOutputToDefaultAudioDevice();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            stopped = false;
            Text_To_Read = richTextBox1.Text;
            if (paused)
            {
                synth.Resume();
                paused = false;
            }
            else
            {
                speak();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.paused = true;
            synth.Pause();
        }

        private void speak()
        {
            synth.SpeakAsync(Text_To_Read);
        }

        private void second_Page_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            //speak();
            synth.SpeakAsync(Text_To_Read);

            paused = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            synth.Dispose();
            stopped = true;
            paused = false;
            //richTextBox1.Select(0,1);
            synth = new SpeechSynthesizer();
            synth.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(speak_in_progress);
        }
    }
}
