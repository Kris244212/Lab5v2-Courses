// ======================================================
// 🧠 Контрольні запитання до лабораторної роботи №5
// Тема: Узагальнені типи (Generics), колекції, LINQ, обробка винятків
// ======================================================

namespace Lab5v2
{
    public static class Questions
    {
        public static void Print()
        {
            Console.WriteLine("\n=== Контрольні запитання ===\n");

            Console.WriteLine("1️⃣ Що таке generics? Які їхні переваги?");
            Console.WriteLine("→ Узагальнені типи (Generics) дозволяють створювати класи, методи та інтерфейси,");
            Console.WriteLine("  що працюють із будь-яким типом даних без дублювання коду.");
            Console.WriteLine("  Переваги: безпека типів, універсальність, повторне використання, швидкість.\n");

            Console.WriteLine("2️⃣ Які основні відмінності між ArrayList і List<T>?");
            Console.WriteLine("→ ArrayList зберігає елементи як object і вимагає приведення типів.");
            Console.WriteLine("  List<T> — типізована колекція, безпечна і швидка.\n");

            Console.WriteLine("3️⃣ Чим відрізняється Dictionary<TKey,TValue> від List<T>?");
            Console.WriteLine("→ List<T> — просто список елементів.");
            Console.WriteLine("  Dictionary<TKey, TValue> — зберігає пари ключ–значення, зручний для швидкого пошуку.\n");

            Console.WriteLine("4️⃣ У чому перевага LINQ над класичними циклами?");
            Console.WriteLine("→ LINQ дозволяє коротко і виразно працювати з колекціями,");
            Console.WriteLine("  використовуючи методи Where, Select, Sum, Average тощо.\n");

            Console.WriteLine("5️⃣ Як працює ключове слово finally?");
            Console.WriteLine("→ finally виконується завжди після try/catch — навіть якщо виникла помилка.");
            Console.WriteLine("  Використовується для звільнення ресурсів (файлів, пам’яті, підключень).\n");

            Console.WriteLine("6️⃣ Коли доцільно створювати власні класи винятків?");
            Console.WriteLine("→ Коли потрібно чітко позначити помилку у своїй предметній області.");
            Console.WriteLine("  Наприклад, DuplicateEnrollmentException — при повторному записі студента.\n");

            Console.WriteLine("======================================================");
            Console.WriteLine("Автор: Кириловець Крістіна Миколаївна");
            Console.WriteLine("Група: КН-3/1, спеціальність 'Комп'ютерні науки'");
            Console.WriteLine("======================================================\n");
        }
    }
}
