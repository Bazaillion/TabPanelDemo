using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabPanelDemo.Models
{
    public class MockData
    {
        public static List<Checkbox> GetTab1()
        {
            List<Checkbox> CBList = new List<Checkbox>()
            {
                new Checkbox(){ Id = "tab1-checkbox", Description = "Checkbox 1", Value = "1", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 400, isChecked = false},
                new Checkbox(){ Id = "tab1-checkbox", Description = "Checkbox 2", Value = "2", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 25, isChecked = false},
            };

            return CBList;
        }

        public static List<Checkbox> GetTab2()
        {
            List<Checkbox> CBList = new List<Checkbox>()
            {
                new Checkbox(){ Id = "tab2-checkbox", Description = "Checkbox 3", Value = "3", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 52, isChecked = false},
                new Checkbox(){ Id = "tab2-checkbox", Description = "Checkbox 4", Value = "4", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 21, isChecked = false},
                new Checkbox(){ Id = "tab2-checkbox", Description = "Checkbox 5", Value = "5", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 5, isChecked = false},
                new Checkbox(){ Id = "tab2-checkbox", Description = "Checkbox 6", Value = "6", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 6, isChecked = false},
                new Checkbox(){ Id = "tab2-checkbox", Description = "Checkbox 7", Value = "7", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 1, isChecked = false},
            };

            return CBList;
        }

        public static List<Checkbox> GetTab3()
        {
            List<Checkbox> CBList = new List<Checkbox>()
            {
                new Checkbox(){ Id = "tab3-checkbox", Description = "Checkbox 8",  Value = "8",  DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 28,  isChecked = false},
                new Checkbox(){ Id = "tab3-checkbox", Description = "Checkbox 9",  Value = "9",  DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 74,  isChecked = false},
                new Checkbox(){ Id = "tab3-checkbox", Description = "Checkbox 10", Value = "10", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 101, isChecked = false},
                new Checkbox(){ Id = "tab3-checkbox", Description = "Checkbox 11", Value = "11", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 211, isChecked = false},
                new Checkbox(){ Id = "tab3-checkbox", Description = "Checkbox 12", Value = "12", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 12, isChecked = false},
                new Checkbox(){ Id = "tab3-checkbox", Description = "Checkbox 13", Value = "13", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 92, isChecked = false},
            };

            return CBList;
        }

        public static List<Checkbox> GetTab4()
        {
            List<Checkbox> CBList = new List<Checkbox>()
            {
                new Checkbox(){ Id = "tab4-checkbox", Description = "Checkbox 14", Value = "14", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 24, isChecked = false},
                new Checkbox(){ Id = "tab4-checkbox", Description = "Checkbox 15", Value = "15", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 38, isChecked = false},
                new Checkbox(){ Id = "tab4-checkbox", Description = "Checkbox 16", Value = "16", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 316, isChecked = false},
                new Checkbox(){ Id = "tab4-checkbox", Description = "Checkbox 17", Value = "17", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 47, isChecked = false},
                new Checkbox(){ Id = "tab4-checkbox", Description = "Checkbox 18", Value = "18", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 8, isChecked = false},
                new Checkbox(){ Id = "tab4-checkbox", Description = "Checkbox 19", Value = "19", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 1, isChecked = false},
                new Checkbox(){ Id = "tab4-checkbox", Description = "Checkbox 20", Value = "20", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 11, isChecked = false},
                new Checkbox(){ Id = "tab4-checkbox", Description = "Checkbox 21", Value = "21", DataId = "f4527f17-c05d-4811-afc7-3bfb65772136", DataFacetName = "", Count = 65, isChecked = false},
                new Checkbox(){ Id = "tab4-checkbox", Description = "Checkbox 22", Value = "22", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 42, isChecked = false},
                new Checkbox(){ Id = "tab4-checkbox", Description = "Checkbox 23", Value = "23", DataId = Guid.NewGuid().ToString(), DataFacetName = "", Count = 23, isChecked = false},
            };

            return CBList;
        }
    }
}
