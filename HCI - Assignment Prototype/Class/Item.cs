using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI___Assignment_Prototype.Class {
   public class Item {
       public Item(string content, bool isSelected = false) {
           Content = content;
           IsSelected = isSelected;
       }

       public Item() {
            IsSelected = false;
           Content = "test content";
       }
       public bool IsSelected { get; set; }
        public string Content { get; set; }
    }
}
