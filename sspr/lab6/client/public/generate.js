class Task {
    // maybe simpify?
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

    #getRandomNumber = (min, max) => (Math.floor(Math.random() * (max - min + 1)) + min);
}