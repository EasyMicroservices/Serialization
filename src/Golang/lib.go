package serialization

type Serializer interface {
}

type StringSerializer interface {
	Serializer
	Serialize(value any) (string, error)
	Deserialize(s string, v any) error
}

func StrSerialize[T any](value T, serializer StringSerializer) (string, error) {
	return serializer.Serialize(value)
}

func StrDeserialize[T any](s string, serializer StringSerializer) (T, error) {
	v := new(T)
	err := serializer.Deserialize(s, v)
	return *v, err
}
