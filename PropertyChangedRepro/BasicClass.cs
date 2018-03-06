using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PropertyChangedRepro
{
    /// <summary>This is a basic class.</summary>
    public class BasicClass : INotifyPropertyChanged
    {
        /// <summary>Whether a boolean is itself true.</summary>
        public bool IsTrue { get; set; }

        public double Number { get; set; }

        /// <summary>Complicated boolean checking algorithm to test the truthfulness of a boolean.</summary>
        /// <param name="test">Boolean value to test.</param>
        /// <returns>Whether the given value is true.</returns>
        public bool IsTheBooleanTrue(bool test)
        {
            return test == true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}