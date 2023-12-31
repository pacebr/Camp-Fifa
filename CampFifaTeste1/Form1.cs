﻿using CampFifa;
using System;
using System.Windows.Forms;

namespace CampFifaTeste1
{
    public partial class Form1 : Form
    {
        private bool comboBoxTimesFilled = false;
        private bool comboBoxTimes1Filled = false;
        private bool comboBoxJogadoresFilled = false;
        private bool comboBoxJogadores1Filled = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void LoadComboBoxTimes()
        {
            if (!comboBoxTimesFilled)
            {
                string vquerytimes = @"
                SELECT
                    id_times,
                    nome_times
                FROM
                    times
                ORDER BY 
                    id_times
                ";
                var timesData = Banco.dql(vquerytimes); // Obtenha os dados uma vez

                comboBox1.DataSource = timesData;
                comboBox1.DisplayMember = "nome_times";
                comboBox1.ValueMember = "id_times";


                comboBoxTimesFilled = true;
            }
        }
        private void LoadComboBoxTimes1()
        {
            if (!comboBoxTimes1Filled)
            {
                string vquerytimes = @"
                SELECT
                    id_times,
                    nome_times
                FROM
                    times
                ORDER BY 
                    id_times
                ";
                var timesData = Banco.dql(vquerytimes); // Obtenha os dados uma vez

                comboBox2.DataSource = timesData; // Preencha a outra ComboBox com os mesmos dados
                comboBox2.DisplayMember = "nome_times";
                comboBox2.ValueMember = "id_times";

                comboBoxTimesFilled = true;
            }
        }

        private void LoadComboBoxJogadores()
        {
            if (!comboBoxJogadoresFilled)
            {
                string vqueryjogadores = @"
                SELECT
                    id_jogador,
                    nome_jogador
                FROM
                    jogadores
                ORDER BY
                    id_jogador
                ";
                var jogadoresData = Banco.dql(vqueryjogadores); // Obtenha os dados uma vez

                cb_nj.DataSource = jogadoresData;
                cb_nj.DisplayMember = "nome_jogador";
                cb_nj.ValueMember = "id_jogador";

                comboBoxJogadoresFilled = true;
            }
        }

        private void LoadComboBoxJogadores1()
        {
            if (!comboBoxJogadores1Filled)
            {
                string vqueryjogadores = @"
                SELECT
                    id_jogador,
                    nome_jogador
                FROM
                    jogadores
                ORDER BY
                    id_jogador
                ";
                var jogadoresData = Banco.dql(vqueryjogadores); // Obtenha os dados uma vez


                cb_nj2.DataSource = jogadoresData; // Preencha a outra ComboBox com os mesmos dados
                cb_nj2.DisplayMember = "nome_jogador";
                cb_nj2.ValueMember = "id_jogador";

                comboBoxJogadores1Filled = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            cb_nj.Text = "";
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            LoadComboBoxTimes();
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            LoadComboBoxTimes1();
        }

        private void cb_nj_Enter(object sender, EventArgs e)
        {
            LoadComboBoxJogadores();
        }

        private void cb_nj2_Enter(object sender, EventArgs e)
        {
            LoadComboBoxJogadores1();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            cb_nj.Text = "";
        }
    }
}
