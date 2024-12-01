class Task {
    constructor(size) {
        this.size = size;
        this.INT16_MAX = 32_767;
        this.INT16_MIN = -32_768;
    }
    generate() {
        const matrix = [...Array(this.size)].map(e => Array(this.size));;
        let buffer = '';

        for (let row = 0; row < this.size; ++row) {
            let rowItems = '';
            for (let cell = 0; cell < this.size; ++cell) {

                const num = this.#getRandomNumber(this.INT16_MIN, this.INT16_MAX);

                rowItems += `<td>${num}</td>`;
                matrix[row][cell] = num;
            }
            buffer += `<tr>${rowItems}</tr>`;
        }

        return { array: matrix, html: buffer };
    }

    static calculate(arr) {

        if (!arr || arr.length <= 1 && arr[0].length <= 1) {
            throw new Error('Невозможно посчитать');
        }

        let min = arr[1][0];

        for (let i = 1; i < arr.length; ++i) {
            for (let j = 0; j < i; ++j) { 
                if (arr[i][j] < min) {
                    min = arr[i][j];
                }
            }
        }

        return min;
    }

    #getRandomNumber = (min, max) => (Math.floor(Math.random() * (max - min + 1)) + min);
}

module.exports = Task;