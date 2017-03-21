using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabPanelDemo.Models
{
    class DAL
    {
        public static List<Tab> GetTabs()
        {
            // create tabs list
            List<Tab> tabs = new List<Tab>();

            // create tab 1 and checkboxes
            Tab tab1 = new Tab();
            tab1.Name = "Tab 1";
            tab1.Checkboxes = GetCheckboxesForTab1();
            tabs.Add(tab1);

            // create tab 2 and checkboxes
            Tab tab2 = new Tab();
            tab2.Name = "Tab 2";
            tab2.Checkboxes = GetCheckboxesForTab2();
            tabs.Add(tab2);

            // create tab 3 and checkboxes
            Tab tab3 = new Tab();
            tab3.Name = "Tab 3";
            tab3.Checkboxes = GetCheckboxesForTab3();
            tabs.Add(tab3);

            // create tab 4 and checkboxes
            Tab tab4 = new Tab();
            tab4.Name = "Tab 4";
            tab4.Checkboxes = GetCheckboxesForTab4();
            tabs.Add(tab4);

            return tabs;
        }

        public static List<Checkbox> GetCheckboxesForTab1()
        {
            return MockData.GetTab1();
        }

        public static List<Checkbox> GetCheckboxesForTab2()
        {
            return MockData.GetTab2();
        }

        public static List<Checkbox> GetCheckboxesForTab3()
        {
            return MockData.GetTab3();
        }

        public static List<Checkbox> GetCheckboxesForTab4()
        {
            return MockData.GetTab4();
        }

    }
}
