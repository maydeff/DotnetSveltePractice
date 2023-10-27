CREATE TABLE threads (
    id SERIAL PRIMARY KEY,
    my_document_key VARCHAR NOT NULL,
    title VARCHAR NOT NULL,
    author VARCHAR NOT NULL,
    created TIMESTAMP WITH TIME ZONE NULL
);
