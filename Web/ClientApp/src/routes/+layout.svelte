<script>
    import Categories from '../Categories.svelte'
    import Header from './Header.svelte'
</script>

<div class="flex flex-col min-h-screen">
    <Header />
    <div class="flex-row">
        <Categories />
        <main class="flex flex-row p-4 bg-cyan-200 box-border">
            <slot />
        </main>
    </div>
</div>

<style>
</style>
