﻿namespace Platform::Collections::Trees
{
    struct HelperTypeTag
    {
    };

    template<typename T>
    struct Repeat : public HelperTypeTag
    {
        using type = T;
    };

    template<typename T>
    concept NotHelperType = !std::derived_from<T, HelperTypeTag>;

    template<typename TValue, typename...>
    class Node;

    template<typename TValue, typename...>
    class Node
    {
        public: std::optional<TValue> Value;

        public: Node() = default;

        public: Node(TValue value)
        {
            Value = value;
        }
    };
/*
    template<typename TValue, NotHelperType TKey, typename ... Tail>
    class Node<TValue, TKey, Tail...>
    {
        using Child = Node<TValue, Tail...>;
        using Dictionary = std::unordered_map<TKey, Child>;

        private: Dictionary* const _childNodes = new Dictionary();

        public: Node() = default;

        public: auto& ChildNodes() { return *_childNodes; }

        public: auto& operator[](TKey key)
        {
            if(!_childNodes->contains(key))
                return AddChild(key);

            return ChildNodes()[key];
        }

        public: auto& AddChild(TKey key, const Node& node = Node{})
        {
            Dictionaries::Add(ChildNodes(), key, node);
            return ChildNodes()[key];
        }

        auto* GetChild(const Interfaces::IEnumerable auto& keys)
        {
            auto* node = this;
            for (const auto& key : keys)
            {
                Dictionary& dictionary = node->ChildNodes();

                if(!dictionary.contains(key))
                    return nullptr;

                node = dictionary[key];
            }
            return node;
        }
    };
*/
    template<typename TValue, typename TKey>
    class Node<TValue, Repeat<TKey>>
    {
        static_assert(std::default_initializable<TValue>);

        public: TValue Value;
        public: using Child = Node;

        private: std::unordered_map<TKey, Child*> _childNodes;
        public: auto ChildNodes() -> auto& { return _childNodes; }

        public: Node(const TValue& value = {})
        {
            Value = value;
        }

        public: auto operator[](const TKey& key) -> Child&
        {
            if(!_childNodes.contains(key))
                return AddChild(key);

            return *_childNodes[key];
        }

        public: auto AddChild(const TKey& key, const TValue& value = {}) -> Child&
        {
            return AddChild(key, Child(value));
        }

        public: auto AddChild(TKey key, const Child& child) -> Child&
        {
            Dictionaries::Add(_childNodes, key, new Child{child});
            return *_childNodes[key];
        }

        public: auto GetChild(const std::vector<TKey>& keys) -> Child*
        {
            auto node = this;
            for (auto&& key : keys)
            {
                node = node->ChildNodes()[key];
                if (node == nullptr)
                {
                    return node;
                }
            }
            return node;
        }

        public: auto GetChildValue(const std::vector<TKey>& keys) -> TValue*
        {
            auto child = GetChild(keys);
            return (child == nullptr) ? nullptr : &child->Value;
        }

        public: auto ContainsChild(const std::vector<TKey>& keys) -> bool
        {
            return GetChild(keys) != nullptr;
        }

        public: auto SetChildValue(const TValue& value, const std::vector<TKey>& keys) -> Child&
        {
            auto node = this;
            for (auto&& key : keys)
            {
                node = &SetChildValue(value, key);
            }
            node->Value = value;
            return *node;
        }

        public: auto SetChildValue(const TValue& value, const TKey& key) -> Child&
        {
            auto& child = (*this)[key];
            child.Value = value;
            return child;
        }

        public: auto SetChild(const std::vector<TKey>& keys) -> Child&
        {
            return SetChildValue(TValue{}, keys);
        }

        public: auto SetChild(TKey key) -> Child&
        {
            SetChildValue(TValue{}, key);
        }
    };
}