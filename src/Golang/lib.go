package serialization

// Serializer is base interface for all serializers.
type Serializer interface {
}

// StringSerializer is an interface that all string serializers should implement it.
type StringSerializer interface {
	Serializer
	Serialize(value any) (string, error)
	Deserialize(s string, v any) error
}

// StrSerialize serializes value to string using given serializer.
func StrSerialize[T any](value T, serializer StringSerializer) (string, error) {
	return serializer.Serialize(value)
}

// StrDeserialize deserializes string to given type using serializer.
func StrDeserialize[T any](s string, serializer StringSerializer) (T, error) {
	v := new(T)
	err := serializer.Deserialize(s, v)
	return *v, err
}
