using System;


namespace University.Events
{
    public class SendPersonIDEventAgs : EventArgs
    {
        public string PersonID { get; }


        public SendPersonIDEventAgs(string personID)
        {
            this.PersonID = personID;
        }
    }
}
