# 🥷 Jumping Ninja

Jumping Ninja, basit ama eğlenceli bir 2D engelden kaçma oyunudur. Oyuncu, boşluk tuşuna basarak ninjanın zıplamasını sağlar ve karşıdan gelen tapınak (temple) engellerinden kaçmaya çalışır. Oyun boyunca puan toplanır ve skor arttıkça oyun hızı da artar.

## 🎮 Oynanış

- **Space Tuşu** ile ninja yukarı zıplar.
- Space tuşu bırakıldığında ninja aşağı düşmeye başlar (yerçekimi etkisi).
- Engellere veya zemine çarparsınız oyun **Game Over** olur.
- 5 puan sonrası tapınak engellerinin hızı artar.

## 🛠️ Teknik Detaylar

- **Yerçekimi**: `int gravity = 5`
- **Engel Hızı**: `int templeSpeed = 8` (skor > 5 ise 15'e çıkar)
- **Puanlama**: Her tapınak başarıyla geçildiğinde +1 puan
- **Çarpışma Algılama**: Ninja'nın engel veya zemine teması

## 📷 Ekran Görüntüleri

### Başlangıç Ekranı
![Screenshot 1](https://github.com/MehmetOKZ/JumpingNinja/blob/master/ASSET/Screenshot-1.png?raw=true)

### Oyun Sırasında
![Screenshot 2](https://github.com/MehmetOKZ/JumpingNinja/blob/master/ASSET/Screenshot-2.png?raw=true)

### Game Over Ekranı
![Screenshot 3](https://github.com/MehmetOKZ/JumpingNinja/blob/master/ASSET/Screenshot-3.png?raw=true)

## 💻 Kod Parçacığı (Ana Oyun Döngüsü)

```csharp
private void gameTimerEvent(object sender, EventArgs e)
{
    jumpingninja.Top += gravity;
    templeBottom.Left -= templeSpeed;
    templeTop.Left -= templeSpeed;
    scoreText.Text = "Score: " + score;

    if(templeBottom.Left < -150)
    {
        templeBottom.Left = 800;
        score++;
    }

    if (templeTop.Left < -180)
    {
        templeTop.Left = 950;
        score++;
    }

    if(jumpingninja.Bounds.IntersectsWith(templeBottom.Bounds) ||
        jumpingninja.Bounds.IntersectsWith(templeTop.Bounds) ||
        jumpingninja.Bounds.IntersectsWith(ground.Bounds))
    {
        endGame();
    }

    if (score > 5)
    {
        templeSpeed = 15;
    }
}

🚀 Başlatmak İçin
1.Visual Studio ile projeyi açın.

2.Form1.cs içindeki kodlar oyun mantığını içerir.

3.F5 ile çalıştırarak oyunu oynayabilirsiniz.

Hazırlayan: MehmetOKZ