#include <Platform.Collections.h>

using namespace Platform::Interfaces;
using namespace Platform::Collections::Trees;
using namespace Platform::Collections::Segments::Walkers;

std::u16string a = u"abacabacalolkekek";

std::u16string elfen_lied = uR"(Nacht im Dorf der Wächter rief: Elfe! Ein ganz kleines Elfchen im Walde schlief wohl um die Elfe! Und meint, es rief ihm aus dem Tal bei seinem Namen die Nachtigall, oder Silpelit hätt' ihm gerufen.
Reibt sich der Elf' die Augen aus, begibt sich vor sein Schneckenhaus und ist als wie ein trunken Mann, sein Schläflein war nicht voll getan, und humpelt also tippe tapp durch’s Haselholz in’s Tal hinab, schlupft an der Mauer hin so dicht, da sitzt der Glühwurm Licht an Licht.
Was sind das helle Fensterlein? Da drin wird eine Hochzeit sein: die Kleinen sitzen bei’m Mahle, und treiben’s in dem Saale. Da guck' ich wohl ein wenig 'nein!"
Pfui, stößt den Kopf an harten Stein! Elfe, gelt, du hast genug? Gukuk!)";

std::u16string real_text =  uR"([english version](https://github.com/Konard/LinksPlatform/wiki/About-the-beginning))
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


auto span_as_string(auto&& span)
{
    std::u16string result;
    std::ranges::for_each(span, [&](auto&& item) { result += item; });
    return result;
}

std::u16string exampleLoremIpsumText = u"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

struct IterationsCounter : public AllSegmentsWalkerBase<IterationsCounter, char16_t>
{
    using base = AllSegmentsWalkerBase<IterationsCounter, char16_t>;
    using base::base;

    std::size_t IterationsCount = 0;

    void Iteration(std::span<char16_t> segment) { IterationsCount++; };
};

template<typename Self>
struct ConsolePrintedDuplicateWalkerBase : DuplicateSegmentsWalkerBase<Self, char16_t>
{
    void OnDuplicateFound(auto segment) {/* std::cout << span_as_string(segment) << "\n"; */}

    std::span<char16_t> CreateSegment(IArray<char16_t> auto&& elements, int offset, int length) { return std::span<char16_t>(std::ranges::begin(elements) + offset, length); }
};


struct Walker1 : public ConsolePrintedDuplicateWalkerBase<Walker1>
{
    using base = ConsolePrintedDuplicateWalkerBase<Walker1>;

    Node<std::size_t, Repeat<char16_t>> _rootNode;
    Node<std::size_t, Repeat<char16_t>>* _currentNode = &_rootNode;

    Walker1() = default;

    void WalkAll(IList<char16_t> auto&& elements)
    {
        _rootNode.ChildNodes().clear();

        base::WalkAll(elements);
    }

    auto GetSegmentFrequency(auto&& segment)
    {
        for (auto&& c : segment)
        {
            auto element = c;

            _currentNode = &(*_currentNode)[element];
        }

        return _currentNode->Value;
    }

    void SetSegmentFrequency(auto&& segment, long frequency) { _currentNode->Value = frequency; };

    void Iteration(auto&& segment)
    {
        _currentNode = &_rootNode;

        base::Iteration(segment);
    }
};

struct Walker2 : ConsolePrintedDuplicateWalkerBase<Walker2>
{
    using base = ConsolePrintedDuplicateWalkerBase<Walker2>;

    std::unordered_map<std::u16string, std::size_t> _cache{};
    std::u16string _currentKey;
    std::size_t _totalDuplicates{};

    Walker2() = default;

    void WalkAll(IArray<char16_t> auto&& elements)
    {
        _cache.clear();

        base::WalkAll(elements);

        std::printf("Unique string segments: %lu. Total duplicates: %lu.\n", _cache.size(), _totalDuplicates);
    }

    void OnDuplicateFound(auto&&) { _totalDuplicates++; }

    auto GetSegmentFrequency(auto&& segment) { return _cache[_currentKey]; }

    auto SetSegmentFrequency(auto&& segment, auto frequency) { _cache[_currentKey] = frequency; }

    void Iteration(auto&& segment)
    {
        _currentKey = std::u16string(std::ranges::begin(segment), std::ranges::end(segment));

        base::Iteration(segment);
    }
};



struct Walker4 : public DictionaryBasedDuplicateSegmentsWalkerBase<Walker4, char16_t>
{
    using base = DictionaryBasedDuplicateSegmentsWalkerBase<Walker4, char16_t>;

    Walker4()
        : base(DefaultMinimumStringSegmentLength, true)
    {
    }

    std::size_t _totalDuplicates{};

    // Automatically '
    //
    // auto CreateSegment(IList auto&& elements, std::int32_t offset, std::int32_t length)
    // {
    //     return std::span<char16_t>(std::ranges::begin(elements) + offset, length);
    // }

    void WalkAll(IArray<char16_t> auto&& elements)
    {
        _totalDuplicates = 0;

        base::WalkAll(elements);

        std::printf("Unique string segments: %lu. Total duplicates: %lu.\n", dictionary.size(), _totalDuplicates);
    }

    void OnDuplicateFound(auto&& segment)
    {
        auto string = span_as_string(segment);
        //std::cout << _totalDuplicates << ": " << std::string(string.begin(), string.end()) << std::endl;
        _totalDuplicates++;
    }
};

#include <random>
#include <chrono>

TEST(Walkers, Sandbox)
{
    auto text = elfen_lied;

    auto iterationsCounter = IterationsCounter{};
    iterationsCounter.WalkAll(text);
    auto result = iterationsCounter.IterationsCount;
    std::printf("TextLength: %lu. Iterations: %lu.\n", text.size(), result);

    {
        auto start = std::chrono::steady_clock::now();

        auto walker2 = Walker2{};
        walker2.WalkAll(text);

        //for (auto [item, count] : walker2._cache) {
        //    std::cout << std::string(item.begin(), item.end()) << " " << count << std::endl;
        //}

        auto end = std::chrono::steady_clock::now();
        std::cout << (std::chrono::duration_cast<std::chrono::milliseconds>(end - start)).count() << "ms\n";
    }

    {
        auto start = std::chrono::steady_clock::now();

        auto walker4 = Walker4{};
        walker4.WalkAll(text);

        //for (auto [item, count] : walker4.dictionary) {
        //    std::cout << std::string(item.begin(), item.end()) << " " << count << std::endl;
        //}
        auto end = std::chrono::steady_clock::now();
        std::cout << (std::chrono::duration_cast<std::chrono::milliseconds>(end - start)).count() << "ms\n";
    }


    {
        auto start = std::chrono::steady_clock::now();

        auto walker1 = Walker1{};
        walker1.WalkAll(text);

        //Platform::Collections::Tests::DFS_print(walker1._rootNode, [](char16_t c) { return char(c); });

        auto end = std::chrono::steady_clock::now();
        std::cout << (std::chrono::duration_cast<std::chrono::milliseconds>(end - start)).count() << "ms\n";
    }
}
