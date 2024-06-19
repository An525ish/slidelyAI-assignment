import { Request, Response } from 'express';
import fs from 'fs';
import path from 'path';

const dbPath = path.join(__dirname, '../db.json');

export const ping = (req: Request, res: Response) => {
  res.json({ success: true });
};

export const submit = (req: Request, res: Response) => {
  const { name, email, phone, github_link, stopwatch_time } = req.body;

  // Read current data
  const data = JSON.parse(fs.readFileSync(dbPath, 'utf8'));
  data.push({ name, email, phone, github_link, stopwatch_time });

  // Write new data
  fs.writeFileSync(dbPath, JSON.stringify(data, null, 2));

  res.json({ success: true });
};

export const read = (req: Request, res: Response) => {
  const index = req.query.index
    ? parseInt(req.query.index as string, 10)
    : null;

  // Read current data
  const data = JSON.parse(fs.readFileSync(dbPath, 'utf8'));

  if (index !== null) {
    if (index >= 0 && index < data.length) {
      res.json(data[index]);
    } else {
      res.status(404).json({ error: 'Not found' });
    }
  } else {
    res.json(data);
  }
};
