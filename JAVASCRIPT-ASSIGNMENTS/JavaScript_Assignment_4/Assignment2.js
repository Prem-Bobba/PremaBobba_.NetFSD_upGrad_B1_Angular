let students = [
  { name: "Akhil", marks: 85 },
  { name: "Priya", marks: 72 },
  { name: "Ravi", marks: 90 },
  { name: "Meena", marks: 45 },
  { name: "Karan", marks: 30 }
];

console.log("Passed:");
console.log(students.filter(s => s.marks >= 40));

console.log("Distinction:");
console.log(students.filter(s => s.marks >= 85));

let avg = students.reduce((sum, s) => sum + s.marks, 0) / students.length;
console.log("Average:", avg);

let topper = [...students].sort((a,b)=>b.marks-a.marks)[0];
console.log("Topper:", topper);

console.log("Failed Count:", students.filter(s=>s.marks<40).length);

let graded = students.map(s => ({
  ...s,
  grade:
    s.marks >= 85 ? "A" :
    s.marks >= 60 ? "B" :
    s.marks >= 40 ? "C" : "Fail"
}));
console.log("Grades:", graded);