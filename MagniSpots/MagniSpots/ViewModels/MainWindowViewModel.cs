using System;
using Avalonia.Media;
using ReactiveUI;

namespace MagniSpots.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
#pragma warning disable CA1822 // Mark members as static
        public string ControlTitle => "Color Picker";
#pragma warning restore CA1822 // Mark members as static

        private Color _selectedColor = new Color(255, 128, 128, 0);

        public Color SelectedColor
        { 
            get => _selectedColor;
            set => this.RaiseAndSetIfChanged(ref _selectedColor, value);
        }
    }
}
