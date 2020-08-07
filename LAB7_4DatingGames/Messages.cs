using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7_4DatingGames
{
    class Messages
    {
            public DatingProfile sender;
            public string messageTitle;
            public string messageData;
            public bool isRead;

            public Messages(DatingProfile sender, string messageTitle, string messageData)
            {
                this.sender = sender;
                this.messageTitle = messageTitle;
                this.messageData = messageData;
                isRead = false;
            }
        }
}
