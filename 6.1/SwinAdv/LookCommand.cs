using System;
using System.ComponentModel;

namespace SwinAdv
{
    public class LookCommand : Command
    {
        // Constructor
        public LookCommand() : base(new string[] { "look" })
        {
        }

        // Execute method
        public override string Execute(Player p, string[] text)
        {
            // Check if the length of input text is not equal to 3 or 5
            if (text.Length != 3 && text.Length != 5)
            {
                return "I don't know how to look like that";
            }

            // Check if the command is "look"
            if (text[0].ToLower() != "look")
            {
                return "Error in look output";
            }

            // Check if the second word is "at"
            if (text[1].ToLower() != "at")
            {
                return "What do you want to look at?";
            }

            // Extract the identifier
            string id = text[2].ToLower();

            // If length is 3
            if (text.Length == 3)
            {
                IHaveInventory container = p;
                string desc = LookAtIn(id, container);
                if (desc == null)
                {
                    return "I can't find the " + text[4];
                }
                return desc;
            }

            // If length is 5
            if (text.Length == 5)
            {
                IHaveInventory container;
                string desc;

                // Check if the fourth word is "in"
                if (text[3].ToLower() != "in")
                {
                    return "What do you want to look in?";
                }

                // Fetch the container
                container = FetchContainer(p, text[4]);
                if (container == null)
                {
                    return "I cannot find the " + text[4];
                }

                // Look at the object in the container
                desc = LookAtIn(id, container);
                if (desc == null)
                {
                    return "I cannot find the " + id + " in the " + container.Name;
                }

                return desc;
            }

            // Return error if neither length is 3 nor 5
            return "Error";
        }

        // Method to fetch the container
        private IHaveInventory? FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as IHaveInventory;
        }

        // Method to look at object in container
        private string LookAtIn(string thingId, IHaveInventory container)
        {
            if (container.Locate(thingId) != null)
            {
                // Returns the full description if the object is found
                return container.Locate(thingId).FullDescription;
            }
            else
            {
                // If the container cannot be found
                return $"I cannot find the {thingId}";
            }
        }
    }
}
