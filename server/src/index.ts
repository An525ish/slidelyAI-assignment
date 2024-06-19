import express from 'express';
import submissionRoutes from './routes/routes';
import fs from 'fs';
import path from 'path';

const app = express();
const port = 3000;

app.use(express.json());

// Ensure db.json exists and initialize if empty
const dbPath = path.join(__dirname, 'db.json');
if (!fs.existsSync(dbPath)) {
  fs.writeFileSync(dbPath, JSON.stringify([]));
}

// Use the routes defined in routes.ts
app.use('/', submissionRoutes);

app.listen(port, () => {
  console.log(`Server running at http://localhost:${port}`);
});
