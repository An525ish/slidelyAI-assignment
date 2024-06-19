import { Router } from 'express';
import { ping, submit, read } from '../controllers/submission';

const router = Router();

// Define routes and map them to controller functions
router.get('/ping', ping);
router.post('/submit', submit);
router.get('/read', read);

export default router;
