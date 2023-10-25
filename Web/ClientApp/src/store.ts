export type Category = {
    id?: number,
    name: string,
    iconName: string,
    numberOfThreads: number,
}

export const categories: Category[] = [
    {
        id: 1,
        name: 'Gaming',
        iconName: 'mdi-light:home',
        numberOfThreads: 5
    },
    {
        id: 2,
        name: 'Science',
        iconName: 'mdi-atom',
        numberOfThreads: 10
    },
    {
        id: 3,
        name: 'Health',
        iconName: 'ic:outline-health-and-safety',
        numberOfThreads: 10
    },
]