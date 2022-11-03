using System;
namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;
        //constructor
        //class newlendiğinde items dizisinin newlenmesi için constructor içinde newlenmiştir.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // newlendiğinde tutulan referanslar silineceğinden geçici dizi oluşturulurak ilk eleman saklanır
            items = new T[items.Length + 1];

            //temparray de geçici tutulan elemanların items dizisine eklenmesi for döngüsü ile yapıldı
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //yeni eklenecek elemanın eklenmesi

        }
    }
}
