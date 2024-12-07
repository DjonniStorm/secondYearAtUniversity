const express = require('express');
const axios = require('axios');
const path = require('path');

const app = express();

app.use(express.static(path.join(__dirname, 'public'))); // html static

app.use(express.json());

app.post('/send-data', async (req, res) => {
    const data = req.body; // get req data

    try {
        const response = await axios.post('http://server_app:3000/', data);
        res.json(response.data);
    } catch (error) {
        console.error('Error sending data to server:', error);
        res.status(500).send('Error sending data to server');
    }
});

app.listen(80, '0.0.0.0', () => {
    console.log(`Server start at 80`);
});