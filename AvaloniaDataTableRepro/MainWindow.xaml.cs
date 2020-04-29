using System.Collections.Generic;
using System.ComponentModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ReactiveUI;

namespace AvaloniaDataTableRepro {
    public class MainWindow : Window {
        public List<TableDataHolder> TableContents { get; }

        public MainWindow() {
            AvaloniaXamlLoader.Load(this);
            TableContents = new List<TableDataHolder>();
            for (var i = 0; i < 25; i++) {
                TableContents.Add(new TableDataHolder {
                    Selected = i % 2 == 0, TextField = $"Test Field {i}"
                });
            }
            DataContext = this;
        }
    }

    public class TableDataHolder {
        public bool Selected { get; set; }
        public string TextField { get; set; }
    }
}