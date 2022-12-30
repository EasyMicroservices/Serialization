package encodingjson

import "encoding/json"

type JsonSerializer struct {
}

func (j JsonSerializer) Serialize(value any) (string, error) {
	res, err := json.Marshal(value)

	if err != nil {
		return "", err
	}
	return string(res), nil
}

func (j JsonSerializer) Deserialize(s string, v any) error {
	return json.Unmarshal([]byte(s), v)
}
