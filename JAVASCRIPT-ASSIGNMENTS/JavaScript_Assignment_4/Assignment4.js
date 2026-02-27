let employees = [
 { id:1, name:"Ravi", dept:"IT", salary:70000 },
 { id:2, name:"Anita", dept:"HR", salary:50000 },
 { id:3, name:"Karan", dept:"IT", salary:80000 },
 { id:4, name:"Meena", dept:"Finance", salary:60000 }
];

let totalSalary = employees.reduce((sum,e)=>sum+e.salary,0);
console.log("Total Salary Expense:", totalSalary);

let sorted = [...employees].sort((a,b)=>b.salary-a.salary);
console.log("Highest:", sorted[0]);
console.log("Lowest:", sorted[sorted.length-1]);

employees = employees.map(e =>
  e.dept === "IT" ? { ...e, salary: e.salary * 1.15 } : e
);

let grouped = employees.reduce((acc,e)=>{
  acc[e.dept] = acc[e.dept] || [];
  acc[e.dept].push(e);
  return acc;
},{});
console.log("Grouped:", grouped);

employees.sort((a,b)=>b.salary-a.salary);
console.log("Sorted Desc:", employees);