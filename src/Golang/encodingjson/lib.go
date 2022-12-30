package encodingjson

import "encoding/json"

// JsonSerializer is a string serializer which uses encoding/json package.
type JsonSerializer struct {
}

// Serialize is implementation of serialize method from StringSerializer interface.
func (j JsonSerializer) Serialize(value any) (string, error) {
	res, err := json.Marshal(value)

	if err != nil {
		return "", err
	}
	return string(res), nil
}

// Deserialize is implementation of deserialize method from StringSerializer interface.
func (j JsonSerializer) Deserialize(s string, v any) error {
	return json.Unmarshal([]byte(s), v)
}
