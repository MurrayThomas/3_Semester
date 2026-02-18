using System;
using System.Collections.Generic;
using System.Text;
using PublishSubscribe_List.Model;

namespace PublishSubscribe_List {

    // Custom event args for event handlers
    public class PersonEventArgs : EventArgs {

        public Person Person { get; set; }

    }

}
