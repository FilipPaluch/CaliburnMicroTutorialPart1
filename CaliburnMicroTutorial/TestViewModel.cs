using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using RandomNameGenerator;

namespace CaliburnMicroTutorial
{
    public class TestViewModel : PropertyChangedBase
    {
        private string _name = "Philip";
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        public void NameChanged()
        {
            Name = NameGenerator.Generate(Gender.Male);
        }
    }
}
