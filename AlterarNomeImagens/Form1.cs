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

namespace AlterarNomeImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    txtFolderPath.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void btnSelectTarget_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    txtTargetFolderPath.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string sourceFolderPath = txtFolderPath.Text;
            string targetFolderPath = txtTargetFolderPath.Text;

            // Lê as IDs antigas e novas a partir dos TextBoxes
            var oldIds = txtIdsOld.Lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
            var newIds = txtIdsNew.Lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

            // Verifica se o número de IDs antigos e novos é o mesmo
            if (oldIds.Length != newIds.Length)
            {
                MessageBox.Show("O número de IDs antigos e novos deve ser o mesmo.");
                return;
            }

            // Cria um mapeamento de IDs antigos para novos
            var renameMap = new Dictionary<string, string>();
            for (int i = 0; i < oldIds.Length; i++)
            {
                renameMap[oldIds[i]] = newIds[i];
            }

            // Verifica se a pasta de origem existe
            if (!Directory.Exists(sourceFolderPath))
            {
                MessageBox.Show("O caminho da pasta de origem não existe.");
                return;
            }

            // Verifica se a pasta de destino existe, se não, cria
            if (!Directory.Exists(targetFolderPath))
            {
                Directory.CreateDirectory(targetFolderPath);
            }

            try
            {
                // Obtém todos os arquivos de imagem na pasta de origem
                string[] files = Directory.GetFiles(sourceFolderPath, "*.jpg")
                    .Concat(Directory.GetFiles(sourceFolderPath, "*.png"))
                    .Concat(Directory.GetFiles(sourceFolderPath, "*.jpeg"))
                    .ToArray();

                // Verifica se existem arquivos
                if (files.Length == 0)
                {
                    MessageBox.Show("Nenhuma imagem encontrada na pasta de origem.");
                    return;
                }

                // Renomeia e copia os arquivos
                foreach (var file in files)
                {
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
                    string fileExtension = Path.GetExtension(file);

                    // Tenta fazer a substituição das IDs
                    foreach (var kvp in renameMap)
                    {
                        if (fileNameWithoutExtension.Contains(kvp.Key))
                        {
                            string newFileName = fileNameWithoutExtension.Replace(kvp.Key, kvp.Value) + fileExtension;
                            string newFilePath = Path.Combine(targetFolderPath, newFileName);

                            // Copia o arquivo com o novo nome
                            File.Copy(file, newFilePath, true);

                            // Mensagem de depuração para cada renomeação/cópia
                            //  MessageBox.Show($"Arquivo copiado: {newFilePath}");
                        }
                    }
                }

                MessageBox.Show("Renomeação e cópia concluídas!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
