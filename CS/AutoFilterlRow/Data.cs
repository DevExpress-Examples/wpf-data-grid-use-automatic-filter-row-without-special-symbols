using System.Collections.Generic;

namespace AutoFilterlRow {
    public class Data {
        public static List<Element> GetData() {
            List<Element> list = new List<Element>();
            for (int i = 0; i < 5; i++) {
                list.Add(new Element() { Name = "Element_" + i, Value = "%" + i + "_%" });
                list.Add(new Element() { Name = "%Element_" + (i + 5), Value = "_" + (i + 5) + "%" });
                list.Add(new Element() { Name = "_Element_" + (i + 10), Value = "%" + (i + 10) + "_" });
            }
            return list;
        }
    }

    public class Element {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
