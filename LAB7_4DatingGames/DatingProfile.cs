using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7_4DatingGames
{
    class DatingProfile
        {
            public string firstname;
            private string lastname;
            public int age;
            public string gender;
            public string bio;
            private List<Messages> myMessages;

            public DatingProfile(string firstname, string lastname, int age, string gender)
            {
                this.firstname = firstname;
                this.lastname = lastname;
                this.age = age;
                this.gender = gender;
                myMessages = new List<Messages>();
            }

            public void WriteBio(string text)
            {
                bio = text;
            }

            public void AddToInbox(Messages message)
            {
                myMessages.Add(message);

            }

            public void SendMessage(string messageTitle, string messageData, DatingProfile sentTo)
            {
                Messages message = new Messages(this, messageTitle, messageData);
                sentTo.AddToInbox(message);
            }

            public void ReadMessage()
            {
                foreach (Messages message in myMessages)
                {
                    if (message.isRead == false)
                    {
                        Console.WriteLine(message.messageTitle);
                        Console.WriteLine(message.messageData);
                        message.isRead = true;
                    }
                }
            }
        }
    }
