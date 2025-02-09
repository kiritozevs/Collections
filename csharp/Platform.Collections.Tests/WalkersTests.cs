using System;
using System.Collections.Generic;
using System.Diagnostics;
using Platform.Collections.Segments;
using Platform.Collections.Segments.Walkers;
using Platform.Collections.Trees;
using Xunit;
using Xunit.Abstractions;


namespace Platform.Collections.Tests
{
    /// <summary>
    /// <para>
    /// Represents the all repeating substrings in string.
    /// </para>
    /// <para></para>
    /// </summary>
    public class AllRepeatingSubstringsInString
    {
        /// <summary>
        /// <para>
        /// The elfen lied.
        /// </para>
        /// <para></para>
        /// </summary>
        private static readonly string elfen_lied = @"Nacht im Dorf der Wächter rief: Elfe! Ein ganz kleines Elfchen im Walde schlief wohl um die Elfe! Und meint, es rief ihm aus dem Tal bei seinem Namen die Nachtigall, oder Silpelit hätt' ihm gerufen.
Reibt sich der Elf' die Augen aus, begibt sich vor sein Schneckenhaus und ist als wie ein trunken Mann, sein Schläflein war nicht voll getan, und humpelt also tippe tapp durch’s Haselholz in’s Tal hinab, schlupft an der Mauer hin so dicht, da sitzt der Glühwurm Licht an Licht.
Was sind das helle Fensterlein? Da drin wird eine Hochzeit sein: die Kleinen sitzen bei’m Mahle, und treiben’s in dem Saale. Da guck' ich wohl ein wenig 'nein!""
Pfui, stößt den Kopf an harten Stein! Elfe, gelt, du hast genug? Gukuk!";
        /// <summary>
        /// <para>
        /// The example text.
        /// </para>
        /// <para></para>
        /// </summary>
        private static readonly string _exampleText =
    @"([english version](https://github.com/Konard/LinksPlatform/wiki/About-the-beginning))
Обозначение пустоты, какое оно? Темнота ли это? Там где отсутствие света, отсутствие фотонов (носителей света)? Или это то, что полностью отражает свет? Пустой белый лист бумаги? Там где есть место для нового начала? Разве пустота это не характеристика пространства? Пространство это то, что можно чем-то наполнить?
[![чёрное пространство, белое пространство](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/1.png ""чёрное пространство, белое пространство"")](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/1.png)
Что может быть минимальным рисунком, образом, графикой? Может быть это точка? Это ли простейшая форма? Но есть ли у точки размер? Цвет? Масса? Координаты? Время существования?
[![чёрное пространство, чёрная точка](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/2.png ""чёрное пространство, чёрная точка"")](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/2.png)
А что если повторить? Сделать копию? Создать дубликат? Из одного сделать два? Может это быть так? Инверсия? Отражение? Сумма?
[![белая точка, чёрная точка](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/3.png ""белая точка, чёрная точка"")](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/3.png)
А что если мы вообразим движение? Нужно ли время? Каким самым коротким будет путь? Что будет если этот путь зафиксировать? Запомнить след? Как две точки становятся линией? Чертой? Гранью? Разделителем? Единицей?
[![две белые точки, чёрная вертикальная линия](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/4.png ""две белые точки, чёрная вертикальная линия"")](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/4.png)
Можно ли замкнуть движение? Может ли это быть кругом? Можно ли замкнуть время? Или остаётся только спираль? Но что если замкнуть предел? Создать ограничение, разделение? Получится замкнутая область? Полностью отделённая от всего остального? Но что это всё остальное? Что можно делить? В каком направлении? Ничего или всё? Пустота или полнота? Начало или конец? Или может быть это единица и ноль? Дуальность? Противоположность? А что будет с кругом если у него нет размера? Будет ли круг точкой? Точка состоящая из точек?
[![белая вертикальная линия, чёрный круг](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/5.png ""белая вертикальная линия, чёрный круг"")](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/5.png)
Как ещё можно использовать грань, черту, линию? А что если она может что-то соединять, может тогда её нужно повернуть? Почему то, что перпендикулярно вертикальному горизонтально? Горизонт? Инвертирует ли это смысл? Что такое смысл? Из чего состоит смысл? Существует ли элементарная единица смысла?
[![белый круг, чёрная горизонтальная линия](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/6.png ""белый круг, чёрная горизонтальная линия"")](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/6.png)
Соединять, допустим, а какой смысл в этом есть ещё? Что если помимо смысла ""соединить, связать"", есть ещё и смысл направления ""от начала к концу""? От предка к потомку? От родителя к ребёнку? От общего к частному?
[![белая горизонтальная линия, чёрная горизонтальная стрелка](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/7.png ""белая горизонтальная линия, чёрная горизонтальная стрелка"")](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/7.png)
Шаг назад. Возьмём опять отделённую область, которая лишь та же замкнутая линия, что ещё она может представлять собой? Объект? Но в чём его суть? Разве не в том, что у него есть граница, разделяющая внутреннее и внешнее? Допустим связь, стрелка, линия соединяет два объекта, как бы это выглядело?
[![белая связь, чёрная направленная связь](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/8.png ""белая связь, чёрная направленная связь"")](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/8.png)
Допустим у нас есть смысл ""связать"" и смысл ""направления"", много ли это нам даёт? Много ли вариантов интерпретации? А что если уточнить, каким именно образом выполнена связь? Что если можно задать ей чёткий, конкретный смысл? Что это будет? Тип? Глагол? Связка? Действие? Трансформация? Переход из состояния в состояние? Или всё это и есть объект, суть которого в его конечном состоянии, если конечно конец определён направлением?
[![белая обычная и направленная связи, чёрная типизированная связь](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/9.png ""белая обычная и направленная связи, чёрная типизированная связь"")](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/9.png)
А что если всё это время, мы смотрели на суть как бы снаружи? Можно ли взглянуть на это изнутри? Что будет внутри объектов? Объекты ли это? Или это связи? Может ли эта структура описать сама себя? Но что тогда получится, разве это не рекурсия? Может это фрактал?
[![белая обычная и направленная связи с рекурсивной внутренней структурой, чёрная типизированная связь с рекурсивной внутренней структурой](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/10.png ""белая обычная и направленная связи с рекурсивной внутренней структурой, чёрная типизированная связь с рекурсивной внутренней структурой"")](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/10.png)
На один уровень внутрь (вниз)? Или на один уровень во вне (вверх)? Или это можно назвать шагом рекурсии или фрактала?
[![белая обычная и направленная связи с двойной рекурсивной внутренней структурой, чёрная типизированная связь с двойной рекурсивной внутренней структурой](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/11.png ""белая обычная и направленная связи с двойной рекурсивной внутренней структурой, чёрная типизированная связь с двойной рекурсивной внутренней структурой"")](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/11.png)
Последовательность? Массив? Список? Множество? Объект? Таблица? Элементы? Цвета? Символы? Буквы? Слово? Цифры? Число? Алфавит? Дерево? Сеть? Граф? Гиперграф?
[![белая обычная и направленная связи со структурой из 8 цветных элементов последовательности, чёрная типизированная связь со структурой из 8 цветных элементов последовательности](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/12.png ""белая обычная и направленная связи со структурой из 8 цветных элементов последовательности, чёрная типизированная связь со структурой из 8 цветных элементов последовательности"")](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/12.png)
...
[![анимация](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/intro-animation-500.gif ""анимация"")](https://raw.githubusercontent.com/Konard/LinksPlatform/master/doc/Intro/intro-animation-500.gif)";


        /// <summary>
        /// <para>
        /// The exam тple text.
        /// </para>
        /// <para></para>
        /// </summary>
        private static readonly string _examТpleText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        
        /// <summary>
        /// <para>
        /// Tests that console tests.
        /// </para>
        /// <para></para>
        /// </summary>
        [Fact]
        public void ConsoleTests()
        {
            string text = elfen_lied;

            var iterationsCounter = new IterationsCounter();
            iterationsCounter.WalkAll(text);
            var result = iterationsCounter.IterationsCount;
            Console.WriteLine($"TextLength: {text.Length}. Iterations: {result}.");

            {
                var start = new Stopwatch();
                start.Start();

                var walker = new Walker4();
                walker.WalkAll(text);

                //foreach (var (key, value) in walker.PublicDictionary)
                //{
                //    Console.WriteLine($"{key} {value}");
                //}

                start.Stop();
                Console.WriteLine($"{start.ElapsedMilliseconds}ms");
            }


            {
                var start = new Stopwatch();
                start.Start();

                var walker = new Walker2();
                walker.WalkAll(text);

                //foreach (var (key, value) in walker._cache)
                //{
                //    Console.WriteLine($"{key} {value}");
                //}

                start.Stop();
                Console.WriteLine($"{start.ElapsedMilliseconds}ms");
            }

            {
                var start = new Stopwatch();
                start.Start();

                var walker = new Walker1();
                walker.WalkAll(text);

                start.Stop();
                Console.WriteLine($"{start.ElapsedMilliseconds}ms");
            }
        }
    }

    /// <summary>
    /// <para>
    /// Represents the console printed dublicate walker base.
    /// </para>
    /// <para></para>
    /// </summary>
    /// <seealso cref="DuplicateSegmentsWalkerBase{char, CharSegment}"/>
    public abstract class ConsolePrintedDublicateWalkerBase : DuplicateSegmentsWalkerBase<char, CharSegment>
    {
        //protected override void OnDublicateFound(CharSegment segment) => Console.WriteLine(segment);

        /// <summary>
        /// <para>
        /// Creates the segment using the specified elements.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="elements">
        /// <para>The elements.</para>
        /// <para></para>
        /// </param>
        /// <param name="offset">
        /// <para>The offset.</para>
        /// <para></para>
        /// </param>
        /// <param name="length">
        /// <para>The length.</para>
        /// <para></para>
        /// </param>
        /// <returns>
        /// <para>The char segment</para>
        /// <para></para>
        /// </returns>
        protected override CharSegment CreateSegment(IList<char> elements, int offset, int length) => new CharSegment(elements, offset, length);
    }
    
    /// <summary>
    /// <para>
    /// Represents the walker.
    /// </para>
    /// <para></para>
    /// </summary>
    /// <seealso cref="ConsolePrintedDublicateWalkerBase"/>
    public class Walker1 : ConsolePrintedDublicateWalkerBase
    {
        /// <summary>
        /// <para>
        /// The root node.
        /// </para>
        /// <para></para>
        /// </summary>
        private Node _rootNode;
        /// <summary>
        /// <para>
        /// The current node.
        /// </para>
        /// <para></para>
        /// </summary>
        private Node _currentNode;

        /// <summary>
        /// <para>
        /// Walks the all using the specified elements.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="elements">
        /// <para>The elements.</para>
        /// <para></para>
        /// </param>
        public override void WalkAll(IList<char> elements)
        {
            _rootNode = new Node();

            base.WalkAll(elements);

            Console.WriteLine(_rootNode.Value);
        }

        /// <summary>
        /// <para>
        /// Ons the dublicate found using the specified segment.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="segment">
        /// <para>The segment.</para>
        /// <para></para>
        /// </param>
        protected override void OnDublicateFound(CharSegment segment)
        {
            
        }

        /// <summary>
        /// <para>
        /// Gets the segment frequency using the specified segment.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="segment">
        /// <para>The segment.</para>
        /// <para></para>
        /// </param>
        /// <returns>
        /// <para>The long</para>
        /// <para></para>
        /// </returns>
        protected override long GetSegmentFrequency(CharSegment segment)
        {
            for (int i = 0; i < segment.Length; i++)
            {
                var element = segment[i];

                _currentNode = _currentNode[element];
            }

            if (_currentNode.Value is int)
            {
                return (int)_currentNode.Value;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// <para>
        /// Sets the segment frequency using the specified segment.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="segment">
        /// <para>The segment.</para>
        /// <para></para>
        /// </param>
        /// <param name="frequency">
        /// <para>The frequency.</para>
        /// <para></para>
        /// </param>
        protected override void SetSegmentFrequency(CharSegment segment, long frequency) => _currentNode.Value = frequency;

        /// <summary>
        /// <para>
        /// Iterations the segment.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="segment">
        /// <para>The segment.</para>
        /// <para></para>
        /// </param>
        protected override void Iteration(CharSegment segment)
        {
            _currentNode = _rootNode;

            base.Iteration(segment);
        }
    }
    
    // Too much memory, but fast
    /// <summary>
    /// <para>
    /// Represents the walker.
    /// </para>
    /// <para></para>
    /// </summary>
    /// <seealso cref="ConsolePrintedDublicateWalkerBase"/>
    public class Walker2 : ConsolePrintedDublicateWalkerBase
    {
        /// <summary>
        /// <para>
        /// The cache.
        /// </para>
        /// <para></para>
        /// </summary>
        public Dictionary<string, long> _cache;
        /// <summary>
        /// <para>
        /// The current key.
        /// </para>
        /// <para></para>
        /// </summary>
        private string _currentKey;
        /// <summary>
        /// <para>
        /// The total duplicates.
        /// </para>
        /// <para></para>
        /// </summary>
        private int _totalDuplicates;

        /// <summary>
        /// <para>
        /// Walks the all using the specified elements.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="elements">
        /// <para>The elements.</para>
        /// <para></para>
        /// </param>
        public override void WalkAll(IList<char> elements)
        {
            _cache = new Dictionary<string, long>();

            base.WalkAll(elements);
            
            Console.WriteLine($"Unique string segments: {_cache.Count}. Total duplicates: {_totalDuplicates}");
        }

        /// <summary>
        /// <para>
        /// Ons the dublicate found using the specified segment.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="segment">
        /// <para>The segment.</para>
        /// <para></para>
        /// </param>
        protected override void OnDublicateFound(CharSegment segment)
        {
            _totalDuplicates++;
        }

        /// <summary>
        /// <para>
        /// Gets the segment frequency using the specified segment.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="segment">
        /// <para>The segment.</para>
        /// <para></para>
        /// </param>
        /// <returns>
        /// <para>The long</para>
        /// <para></para>
        /// </returns>
        protected override long GetSegmentFrequency(CharSegment segment) => _cache.GetOrDefault(_currentKey);

        /// <summary>
        /// <para>
        /// Sets the segment frequency using the specified segment.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="segment">
        /// <para>The segment.</para>
        /// <para></para>
        /// </param>
        /// <param name="frequency">
        /// <para>The frequency.</para>
        /// <para></para>
        /// </param>
        protected override void SetSegmentFrequency(CharSegment segment, long frequency) => _cache[_currentKey] = frequency;

        /// <summary>
        /// <para>
        /// Iterations the segment.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="segment">
        /// <para>The segment.</para>
        /// <para></para>
        /// </param>
        protected override void Iteration(CharSegment segment)
        {
            _currentKey = segment;

            base.Iteration(segment);
        }
    }
    
    /// <summary>
    /// <para>
    /// Represents the walker.
    /// </para>
    /// <para></para>
    /// </summary>
    /// <seealso cref="DictionaryBasedDuplicateSegmentsWalkerBase{char, CharSegment}"/>
    public class Walker4 : DictionaryBasedDuplicateSegmentsWalkerBase<char, CharSegment>
    {
        /// <summary>
        /// <para>
        /// Gets the public dictionary value.
        /// </para>
        /// <para></para>
        /// </summary>
        public IDictionary<CharSegment, long> PublicDictionary
        {
            get
            {
                return Dictionary;
            }
        }

        /// <summary>
        /// <para>
        /// Initializes a new <see cref="Walker4"/> instance.
        /// </para>
        /// <para></para>
        /// </summary>
        public Walker4()
            : base(DefaultMinimumStringSegmentLength, resetDictionaryOnEachWalk: true)
        {
        }

        /// <summary>
        /// <para>
        /// The total duplicates.
        /// </para>
        /// <para></para>
        /// </summary>
        private int _totalDuplicates;

        /// <summary>
        /// <para>
        /// Walks the all using the specified elements.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="elements">
        /// <para>The elements.</para>
        /// <para></para>
        /// </param>
        public override void WalkAll(IList<char> elements)
        {
            _totalDuplicates = 0;

            base.WalkAll(elements);
            Console.WriteLine($"Unique string segments: {Dictionary.Count}. Total duplicates: {_totalDuplicates}.");
        }

        /// <summary>
        /// <para>
        /// Creates the segment using the specified elements.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="elements">
        /// <para>The elements.</para>
        /// <para></para>
        /// </param>
        /// <param name="offset">
        /// <para>The offset.</para>
        /// <para></para>
        /// </param>
        /// <param name="length">
        /// <para>The length.</para>
        /// <para></para>
        /// </param>
        /// <returns>
        /// <para>The char segment</para>
        /// <para></para>
        /// </returns>
        protected override CharSegment CreateSegment(IList<char> elements, int offset, int length) => new CharSegment(elements, offset, length);

        /// <summary>
        /// <para>
        /// Ons the dublicate found using the specified segment.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="segment">
        /// <para>The segment.</para>
        /// <para></para>
        /// </param>
        protected override void OnDublicateFound(CharSegment segment)
        {
            _totalDuplicates++; 
        }
    }

    /// <summary>
    /// <para>
    /// Represents the iterations counter.
    /// </para>
    /// <para></para>
    /// </summary>
    /// <seealso cref="AllSegmentsWalkerBase{char}"/>
    public class IterationsCounter : AllSegmentsWalkerBase<char>
    {
        /// <summary>
        /// <para>
        /// The iterations count.
        /// </para>
        /// <para></para>
        /// </summary>
        public long IterationsCount;

        /// <summary>
        /// <para>
        /// Iterations the segment.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="segment">
        /// <para>The segment.</para>
        /// <para></para>
        /// </param>
        protected override void Iteration(Segment<char> segment) => IterationsCount++;
    }
}
