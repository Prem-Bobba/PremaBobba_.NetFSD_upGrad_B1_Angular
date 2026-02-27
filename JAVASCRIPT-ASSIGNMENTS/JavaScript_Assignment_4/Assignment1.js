let books = [
  { id: 1, title: "JavaScript Basics", price: 450, stock: 10 },
  { id: 2, title: "React Guide", price: 650, stock: 5 },
  { id: 3, title: "Node.js Mastery", price: 550, stock: 8 },
  { id: 4, title: "CSS Complete", price: 300, stock: 12 }
];

console.log("All Titles:");
books.map(b => b.title).forEach(t => console.log(t));

let totalValue = books.reduce((sum, b) => sum + (b.price * b.stock), 0);
console.log("Total Inventory Value:", totalValue);

console.log("Books above ₹500:");
console.log(books.filter(b => b.price > 500));

books = books.map(b => ({ ...b, price: Math.round(b.price * 1.05) }));

books.sort((a, b) => a.price - b.price);

books = books.filter(b => b.id !== 2);

console.log("Any Out of Stock:", books.some(b => b.stock === 0));

let invoice = books.map(b => `${b.title} - ₹${b.price}`).join("\n");
console.log("Invoice:\n" + invoice);