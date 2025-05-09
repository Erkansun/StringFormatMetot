string.Format() metotunun kullanımına dair bir örnektir.

Console.WriteLine(string.Format("{0,-12} | {1,-20} | {2:0000000} | {3:(###) ### ## ##} |",TCno1,adiSoyad1,maas1,telefon1));

* string.Format("{0,-12}", TCno1)); 0 ile ilk değişkeni işaret ediyoruz (TCno1). Virgülden sonraki -12 ile eksi(-) işareti soldan hizalı yazılacağını ve 12 karakterlik yer kaplayacağını söylüyoruz.

* string.Format("{2:0000000}", maas1)); 2 ile 3cü sıradaki değişkeni işaret ediyoruz (maas1). İki nokta üstüste (:) işareti, sonradan yazılan 7 adet sıfır (0000000) ile 7 karakkter içereceğini,
* eğer gelen veri 7 karakterden az olması durumunda da 7 karaktere tamamlanacak şekilde sıfır (0) eklenir.

* string.Format("{3:(###) ### ## ##}", telefon1)); 3 ile son değişken işaret ediliyor (telefon1). double tipinde oluşturulan telefon değişkeni sayesinde veri formatlı bir şekilde değişkene tanımlanmasa dahi
* (###) ### ## ## şeklinde yazılması sağlandı.
