using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Xlsx
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Produto> produtos = new List<Produto>();
			Produto produto1 = new Produto() {
				Id = 1,
				Nome = "Martelo",
				Valor = 50.25,
				DataProducao = new DateTime(2019, 12, 25)
			};
			Produto produto2 = new Produto()
			{
				Id = 2,
				Nome = "Parafuso",
				Valor = 1.15,
				DataProducao = new DateTime(2018, 05, 13)
			};
			Produto produto3 = new Produto()
			{
				Id = 3,
				Nome = "Furadeira",
				Valor = 250.92,
				DataProducao = new DateTime(2021, 09, 05)
			};
			produtos.Add(produto1);
			produtos.Add(produto2);
			produtos.Add(produto3);

			DataTable tabela = new DataTable();
			tabela.Columns.Add("Id", typeof(int));
			tabela.Columns.Add("Nome", typeof(string));
			tabela.Columns.Add("Valor", typeof(double));
			tabela.Columns.Add("Data Produção", typeof(string));
			
			foreach (var produto in produtos)
			{
				DataRow linha = tabela.NewRow();
				linha[0] = produto.Id;
				linha[1] = produto.Nome;
				linha[2] = produto.Valor;
				linha[3] = produto.DataProducao.ToString("dd/MM/yyyy");
				tabela.Rows.Add(linha);
			}

			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
			using (ExcelPackage excelPackage = new ExcelPackage(new MemoryStream()))
			{
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
				worksheet.Cells["A1"].LoadFromDataTable(tabela, true, TableStyles.None);
				worksheet.Cells["A1:AN1"].Style.Font.Bold = true;
				worksheet.Cells.AutoFitColumns();
                byte[] arquivoEmBytes = excelPackage.GetAsByteArray();
				File.WriteAllBytes(@"D:\meuArquivoExcel.xlsx", arquivoEmBytes);
			}
		}
    }
}