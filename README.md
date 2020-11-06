# FRESH FRUIT
Freash Fruit adalah sebuah aplikasi yang digunakan untuk menambahkan buah-buahan kedalam sebuah keranjang yang mana keranjang tersebut dapat dibatasi kapasistasnya , 
Pada Aplikasi ini juga terdapat konsep MVC (Model View Controller).

## SCOPE & FUNCTIONALITIES
- User dapat menekan tombol Add untuk menambahkan buah/fruit yang diinginkan
- User dapat melihat  nama buah yang sudah di ADD kedalam keranjang (Listbox)


## HOW DOES IT WORKS?
Pada Method `Fruit.cs` itu merupakan Logic View yang digunakan untuk menampilkan nama buah pada listbox. berikut merupakan source codenya
``` csharp
  class Fruit
    {
        public string name { get; set; }


        public Fruit(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
    }
``` 
logic model bisnis pada `MainWindow.xaml.cs` digunakan untuk menambahkan buah dengan cara menekan tombol ADD pada setiap gambar , dan menampilkannya pada listbox melalui method `Fruit.cs`.
berikut merupakan source code pada `MainWindow.xaml.cs`
``` csharp
   private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            RDj.addFruit(anggur);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddApelClicked(object sender, RoutedEventArgs e)
        {
            Fruit apel = new Fruit("Apel");
            RDj.addFruit(apel);

            ListBoxBucket.Items.Refresh();

        }

        private void OnButtonAddPisangClicked(object sender, RoutedEventArgs e)
        {
            Fruit Pisang = new Fruit("Pisang");
            RDj.addFruit(Pisang);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddJerukClicked(object sender, RoutedEventArgs e)
        {
            Fruit Jeruk = new Fruit("Jeruk");
            RDj.addFruit(Jeruk);

            ListBoxBucket.Items.Refresh();
        }
```
```
Terimakasih  😃
```
