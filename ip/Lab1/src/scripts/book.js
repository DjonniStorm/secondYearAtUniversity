import ePub from 'epubjs';

class BookReader {
  get totalPages() {
    return this.book.locations.length;
  }

  constructor(bookPath) {
    this.book = ePub(bookPath);
    this.pageNum = this._loadNum();

    (async () => {
      await this.init();
    })();
  }

  _loadNum() {
    try {
      const num = JSON.parse(localStorage.getItem('pageNum'));

      if (Number.isFinite(num)) {
        return Number.parseInt(num);
      }

      return 0;
    } catch {
      return 0;
    }
  }

  async init() {
    await this.book.ready;
    this.rendition = this.book.renderTo('area', {
      allowScriptedContent: true,
      height: '100%',
      width: '100%',
    });
    await this.display();
  }

  nextPage() {
    this.pageNum =
      this.pageNum === this.book.spine.length - 1
        ? this.pageNum
        : this.pageNum + 1;

    this._saveNum();
  }

  _saveNum() {
    try {
      localStorage.setItem('pageNum', JSON.stringify(this.pageNum));
      // eslint-disable-next-line no-empty
    } catch {}
  }

  prevPage() {
    this.pageNum = this.pageNum === 0 ? 0 : this.pageNum - 1;

    this._saveNum();
  }

  async display() {
    await this.rendition.display(this.pageNum);
  }
}

let reader;

function getBookFromSearchParams() {
  const params = new URLSearchParams(window.location.search);
  const bookPath = params.get('book').replace('-', '');

  console.log(bookPath);

  if (!bookPath) {
    throw new Error('Book path not found in search params');
  }

  return bookPath.concat('.epub');
}

document.addEventListener('DOMContentLoaded', () => {
  const bookPath = getBookFromSearchParams();

  reader = new BookReader(bookPath);
});

const [prev, next] = document.querySelectorAll('button');

prev.addEventListener('click', async () => {
  reader.prevPage();
  await reader.display();
});

next.addEventListener('click', async () => {
  reader.nextPage();
  await reader.display();
});
