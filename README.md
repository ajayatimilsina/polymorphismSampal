# polymorphismSampal
यो VB.NET कोडलाई सजिलो नेपालीमा बुझौं (nepalima buzaideu)। यो कोडमा **Object-Oriented Programming (OOP)** को **Inheritance (अंशग्रहण)** र **Polymorphism** को प्रयोग गरेर 'एनिमल कुकीज' (Animal Cookies) को एउटा रमाइलो एप बनाइएको छ।

यहाँ प्रत्येक भागले के गर्छ, सरल रूपमा व्याख्या गरिएको छ:

---

### 1. Animal Class (मुख्य वा अभिभावक क्लास)

यो सबै जनावरहरूको लागि एउटा साझा "मदर क्लास" (Parent Class) हो।

* **विशेषताहरू (Properties):** सबै जनावरको रङ (color) "ब्राउन/चिया", बासना (smell) "कॉफी", र स्वाद (Flavor) "चॉकलेट" हुन्छ।
* **काम (Functions):**
* Sing(): यो चल्दा AnimalCookieSing भन्ने इमेज (फोटो) आउँछ।
* Reset(): यो चल्दा AnimalCookie भन्ने सामान्य फोटो आउँछ।


* **Overridable को अर्थ:** यसको मतलब यो हो कि पछि अरू क्लास (जस्तै Dog, Cat) ले यसलाई आफ्नो इच्छा अनुसार परिवर्तन गर्न सक्छन्।

---

### 2. Bird, Cat, र Dog Classes (बालबालिका क्लासहरू)

यी तीनवटै क्लासहरूले Inherits Animal गरेका छन्। अर्थात्, यिनीहरूले Animal को रङ, स्वाद र बासना स्वतः पाउँछन्, तर आफ्नै विशेषता र फोटो पनि थपेका छन्।

* **Bird (चरा):** यसको आफ्नै चुच्चो (Beak = "त्रिकोण") छ। यसले Sing() गर्दा चरा कराएको फोटो (BirdcookieSing) र Reset() गर्दा चराको सामान्य फोटो (Birdcookie) देखाउँछ।
* **Cat (बिरालो):** यसको आफ्नै कान (Ear = "गोलो") छ। यसले बिरालोको फोटोहरू (CatCookieSing / CatCookie) देखाउँछ।
* **Dog (कुकुर):** यसको आफ्नै नाक (Nose = "गोलो") छ। यसले कुकुरको फोटोहरू (DogCookieSing / DogCookie) देखाउँछ।
* **Overrides को अर्थ:** "माथि अभिभावक (Animal) को नियम जे भए पनि, मेरो आफ्नै फोटो देखाउँछु" भनिएको हो।

---

### 3. Form1 (बटन र फोटोहरू चलाउने ठाउँ)

#### 🔘 ButtonSing_Click (गीत गाउने बटन थिच्दा)

यो बटन थिच्दा कुकुर, बिरालो र चरा तीनवटैको नयाँ अबजेक्ट (Object) बन्छ र आ-आफ्नो Sing() फंक्शन चल्छ।

* PictureBoxDog मा कुकुर कराएको फोटो आउँछ।
* PictureBoxCat मा बिरालो कराएको फोटो आउँछ Ori।
* PictureBoxBird मा चरा कराएको फोटो आउँछ।

#### 🔘 ButtonReset_Click (रिसेट बटन थिच्दा)

यो बटन थिच्दा सबै जनावरहरू फेरि सामान्य अवस्थामा फर्किन्छन्।

* तीनवटै PictureBox मा पुराना सामान्य फोटोहरू (Reset() भएका फोटो) वापस आउँछन्।

#### 🖼️ PictureBox1_Click

कुकुर, बिरालो वा चराको फोटोमा क्लिक गर्दा के हुने भन्ने ठाउँ हो, तर अहिले यो खाली छ (यसले केही गर्दैन)।

---
Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxDog.Click, PictureBoxCat.Click, PictureBoxBird.Click

    End Sub

    Private Sub ButtonSing_Click(sender As Object, e As EventArgs) Handles ButtonSing.Click
        animalCookis = New Dog（）
        PictureBoxDog.Image = animalCookis.Sing()
        animalCookis = New Cat（）
        PictureBoxCat.Image = animalCookis.Sing()
        animalCookis = New Bird（）
        PictureBoxBird.Image = animalCookis.Sing()

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        animalCookis = New Dog（）
        PictureBoxDog.Image = animalCookis.Reset()
        animalCookis = New Cat（）
        PictureBoxCat.Image = animalCookis.Reset()
        animalCookis = New Bird（）
        PictureBoxBird.Image = animalCookis.Reset()

    End Sub
End Class

### ⚠️ कोडमा सानो गल्ती (Error) र सुधार

तपाईंको कोडमा २ वटा साना गल्तीहरू छन् जसले गर्दा एरर (Error) आउन सक्छ:

1. **ब्र्याकेटको गल्ती:** New Dog（） मा नेपाली/जापानी फुल-वाइथ ब्र्याकेट （） प्रयोग भएको छ। यसलाई अंग्रेजी आधा ब्र्याकेट () बनाउनुपर्छ।
2. **भ्यारिएबल घोषणा:** animalCookies लाई कतै पनि Dim गरिएको छैन।

**सच्चिएको कोड (Corrected Code):**

```vb
Public Class Form1
    ' animalCookies लाई यहाँ Declare गर्नुपर्छ
    Dim animalCookies As Animal 

    Private Sub ButtonSing_Click(sender As Object, e As EventArgs) Handles ButtonSing.Click
        animalCookies = New Dog() ' () लाई अंग्रेजी बनाउने
        PictureBoxDog.Image = animalCookies.Sing()
        animalCookies = New Cat()
        PictureBoxCat.Image = animalCookies.Sing()
        animalCookies = New Bird()
        PictureBoxBird.Image = animalCookies.Sing()
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        animalCookies = New Dog()
        PictureBoxDog.Image = animalCookies.Reset()
        animalCookies = New Cat()
        PictureBoxCat.Image = animalCookies.Reset()
        animalCookies = New Bird()
        PictureBoxBird.Image = animalCookies.Reset()
    End Sub
End Class

```

बुझ्न सजिलो भयो? केही दुविधा भए सोध्नुहोला!
