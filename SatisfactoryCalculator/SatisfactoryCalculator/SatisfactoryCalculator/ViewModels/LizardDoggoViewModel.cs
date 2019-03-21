using Xamarin.Forms;

namespace SatisfactoryCalculator.ViewModels
{
    public class LizardDoggoViewModel : BaseViewModel
    {
        public string AmountDisplay => $"The Lizard Doggo has been pet {TimesPet} times";

        private int _timesPet = 0;
        public int TimesPet
        {
            get
            {
                return _timesPet;
            }
            set
            {
                _timesPet = value;
                this.OnPropertyChanged(nameof(AmountDisplay));
            }
        }

        public LizardDoggoViewModel()
        {
            TimesPet = 0;
        }
    }
}
