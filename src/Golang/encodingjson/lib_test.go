package encodingjson_test

import (
	serialization "github.com/EasyMicroservices/Serialization"
	"github.com/EasyMicroservices/Serialization/encodingjson"
	"github.com/stretchr/testify/assert"
	"testing"
)

type TestStruct struct {
	Int     int     `json:"int"`
	Float   float32 `json:"float"`
	Str     string  `json:"str"`
	Boolean bool    `json:"boolean"`
	Array   []int   `json:"array"`
}

func TestStrSerializeWithEncodingJson(t *testing.T) {
	ts := TestStruct{
		Int:     1,
		Float:   3.2,
		Str:     "test str",
		Boolean: false,
		Array:   []int{1, 2, 3},
	}
	expectedJson := "{\"int\":1,\"float\":3.2,\"str\":\"test str\",\"boolean\":false,\"array\":[1,2,3]}"

	serialized, err := serialization.StrSerialize[TestStruct](ts, new(encodingjson.JsonSerializer))
	assert.Nil(t, err)
	assert.Equal(t, expectedJson, serialized)
}

func TestStrDeserializeWithEncodingJson(t *testing.T) {
	jsonStr := "{\"int\":1,\"float\":3.2,\"str\":\"test str\",\"boolean\":false,\"array\":[1,2,3]}"
	expectedValue := TestStruct{
		Int:     1,
		Float:   3.2,
		Str:     "test str",
		Boolean: false,
		Array:   []int{1, 2, 3},
	}

	deserialized, err := serialization.StrDeserialize[TestStruct](jsonStr, new(encodingjson.JsonSerializer))
	assert.Nil(t, err)
	assert.Equal(t, expectedValue, deserialized)
}
