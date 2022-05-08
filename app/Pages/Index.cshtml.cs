﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;

namespace app.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<string> myList = new List<string>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            try
            {
                string connectionString = "Server=ROG-WORKSTATION\\SQLEXPRESS;Database=easyManageDb;Integrated Security=true";

                string sql = "SELECT [NOME] FROM [easyManageDb].[dbo].[ATIVO]";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                myList.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }
    }
}
