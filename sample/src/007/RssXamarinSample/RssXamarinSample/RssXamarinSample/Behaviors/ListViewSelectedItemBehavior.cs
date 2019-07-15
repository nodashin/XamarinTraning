using RssXamarinSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RssXamarinSample.Behaviors
{
    public class ListViewSelectedItemBehavior : Behavior<ListView>
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(ListViewSelectedItemBehavior), null);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public ListView target { get; private set; }

        protected override void OnAttachedTo(ListView argTarget)
        {
            base.OnAttachedTo(argTarget);

            this.target = argTarget;

            argTarget.BindingContextChanged += OnBindingContextChanged;
            argTarget.ItemSelected += OnListViewItemSelected;
        }

        protected override void OnDetachingFrom(ListView argTarget)
        {
            base.OnDetachingFrom(argTarget);

            argTarget.BindingContextChanged -= OnBindingContextChanged;
            argTarget.ItemSelected -= OnListViewItemSelected;

            this.target = null;
        }

        void OnBindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (Command == null)
            {
                return;
            }

            Article article = (sender as ListView).SelectedItem as Article;

            if (Command.CanExecute(article))
            {
                Command.Execute(article);
            }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            BindingContext = this.target.BindingContext;
        }
    }
}
