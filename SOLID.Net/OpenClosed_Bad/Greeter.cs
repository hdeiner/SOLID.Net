using System;

namespace SOLID.Net.OpenClosed_Bad
{
    public class Greeter
    {
        String formality;

        public String greet() {
            if (this.formality == "formal") {
                return "Good evening, sir.";
            }
            else if (this.formality == "casual") {
                return "Sup bro?";
            }
            else if (this.formality == "intimate") {
                return "Hello Darling!";
            }
            else {
                return "Hello.";
            }
        }

        public void setFormality(String formality) {
            this.formality = formality;
        }

    }
}