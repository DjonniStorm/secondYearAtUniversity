const express = require('express');
const axios = require('axios');
const app = express():

app.use(express.json());

app.post('/fetch-data', (req, res) => {
 console.log(req.body);
	//todo
})

app.listen(3000, () => console.log('server starts at 3000'));
