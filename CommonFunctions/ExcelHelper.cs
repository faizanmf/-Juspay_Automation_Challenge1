using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;

public class ExcelHelper
{
    
    public static List<TestData> ReadTestData(string filePath)
    {
        var testDataList = new List<TestData>();

        using (var package = new ExcelPackage(new FileInfo(filePath)))
        {
            var worksheet = package.Workbook.Worksheets[0]; 

            for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
            {
                var productName = worksheet.Cells[row, 1].Text;
                var email = worksheet.Cells[row, 2].Text;
                var mobile = worksheet.Cells[row, 3].Text;

                testDataList.Add(new TestData
                {
                    ProductName = productName,
                    Email = email,
                    Mobile = mobile
                });
            }
        }

        return testDataList;
    }
}

public class TestData
{
    public string ProductName { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
}
