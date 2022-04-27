# LA1500

# Bewegungen in WinForms mit oder ohne gedrückte Tasten

## Einleitung
Hier wird erklärt, wie Sie eine Figur auf Winforms mit Tasten bewegen können oder eine grössere Gruppe automatisch.

__Was ist Windows Forms?__

`Windows Forms` ist neben der 'normalen' Konsole ein Programm in Visual Studio, das dem Benutzer ermöglicht, in verschiedenen Feldern Features einzufügen. Mit `Windows Forms` kann man mit den Feautures wie in der Konsole den Benutzer zu einer Eingabe auffordern, jedoch kann man mit den Labels und anderen Sachen die Gestaltung schöner und übersichtlicher als auf der Konsole gestalten. Es ermöglicht auch die Erstellung grafischer Benutzeroberflächen für Windows. In unserer Gruppenarbeit haben wir uns für `WinForms` entschieden, da unser Spiel Space Invaders mit diesem Programm einfach zu programmieren ist.

__Was ist Space Invaders?__

Space Invaders ist ein japanisches Videospiel, in dem man mit einem Raumschiff Aliens abschiesst. Der Spieler steuert das Raumschiff mit den rechten und linken Pfeiltasten und schiesst Geschosse mit der Leertaste. Jedes Level beginnt mit mehreren Reihen regelmässig angeordneter Aliens, die sich ständig horizontal und dabei nach und nach abwärts bewegen. Der Spieler selbst hat einen unbegrenzten Munitionsvorrat, kann aber erst dann ein neues Geschoss abfeuern, wenn das vorige vom Bildschirm verschwunden ist. Wenn es einem der Aliens gelingt, den unteren Bildschirmrand zu erreichen und neben der Kanone zu landen, verliert der Spieler eines seiner Leben.

## Unsere Ziele
1. Dem Leser erklären, wie ein KeyPress Event in WinForms ausgeführt wird.
2. Dem Leser erklären, wie man die Bewegung der Gegner in WinForms codiert und ausführt. 

## Erklärung

In unserem Game wollen wir etwas nach dem Vorbild von Space Invaders programmieren. Wir hätten uns gedacht, dass wir ein Upgrade System machen. Zum Beispiel kann man sich mit Münzen rechts und links Towers kaufen. Die Coins erhält man, wenn man die Gegner abschiesst. Je besser das Upgrade, je mehr Münzen kosten sie. Auch wollen wir verschiedene Modis einfügen, wie beim Game Pineapple-Apple-Pen. Man kann die Gegner an einem Punkt lassen, gerade auf einen zukommen lassen, oder im Zickzack fliegen lassen.

## Code

```csharp
  //Move Invaders Left or Right
                for (int i = 1; i <= numinvaders; i++) //Die Variable, damit das Bild sich bewegt
                {
                    PictureBox img = invader[i];
                    img.Left += movement;
                }

                cycle++;
                if (cycle == 62)
                {
                    movement *= -1;
                    cycle = 0;

                    // Move invaders a little down
                    for (int i = 1; i <= numinvaders; i++)
                    {
                        PictureBox img = invader[i];
                        img.Top += movement2;
                    }
                    down++;
// Player Input Routine
        public void frmInvaders_KeyPress(object sender, KeyPressEventArgs e)
        {
            int n = e.KeyChar; //Tastatur

            // Left
            if (gamestart && (n == 52  n == 97) && Defender.Left > 25)
            {
                Defender.Left -= 15;
            }

            // Right
            if (gamestart && (n == 54  n == 100) && Defender.Left < 720)
            {
                Defender.Left += 15;
            }
```

## Video

<a href="https://youtu.be/oDYmfFeIIhA" title="Video Spiel"><img src="{image-url}" alt="Video Spiel" /></a>


## Verifikation

1. Dem Leser erklären, wie ein KeyPress Event in WinForms ausgeführt wird.
  - Wurde im Code erklärt
3. Dem Leser erklären, wie man die Bewegung der Gegner in WinForms codiert und ausführt. 
  - Wurde im Code erklärt

## Reflexion
