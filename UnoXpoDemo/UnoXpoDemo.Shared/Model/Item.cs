using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnoXpoDemo.Shared.Model
{
    public class Item : XPObject
    {
        public Item()
        {
        }
        public Item(Session session) : base(session)
        {
        }

        string _name;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => _name;
            set => SetPropertyValue(nameof(Name), ref _name, value);
        }

        string description;
        public string Description
        {
            get { return description; }
            set { SetPropertyValue("Description", ref description, value); }
        }

        bool _active;
        public bool Active
        {
            get => _active;
            set => SetPropertyValue(nameof(Active), ref _active, value);
        }


    }
}
