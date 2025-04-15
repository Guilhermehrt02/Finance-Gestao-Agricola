export class ReportInput {
    startDate!: Date;
    endDate!: Date;
    category?: string[] | null;
    source?: string[] | null;
}