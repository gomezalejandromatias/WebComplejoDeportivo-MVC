---
name: Athletic Campus Management
colors:
  surface: '#f8f9fa'
  surface-dim: '#d9dadb'
  surface-bright: '#f8f9fa'
  surface-container-lowest: '#ffffff'
  surface-container-low: '#f3f4f5'
  surface-container: '#edeeef'
  surface-container-high: '#e7e8e9'
  surface-container-highest: '#e1e3e4'
  on-surface: '#191c1d'
  on-surface-variant: '#3e4941'
  inverse-surface: '#2e3132'
  inverse-on-surface: '#f0f1f2'
  outline: '#6e7a70'
  outline-variant: '#bdcabe'
  surface-tint: '#006d41'
  primary: '#006c40'
  on-primary: '#ffffff'
  primary-container: '#198754'
  on-primary-container: '#ffffff'
  inverse-primary: '#77da9f'
  secondary: '#2d6a48'
  on-secondary: '#ffffff'
  secondary-container: '#b0f1c7'
  on-secondary-container: '#33704e'
  tertiary: '#0056cc'
  on-tertiary: '#ffffff'
  tertiary-container: '#0a6dfc'
  on-tertiary-container: '#ffffff'
  error: '#ba1a1a'
  on-error: '#ffffff'
  error-container: '#ffdad6'
  on-error-container: '#93000a'
  primary-fixed: '#93f7ba'
  primary-fixed-dim: '#77da9f'
  on-primary-fixed: '#002110'
  on-primary-fixed-variant: '#00522f'
  secondary-fixed: '#b0f1c7'
  secondary-fixed-dim: '#95d4ac'
  on-secondary-fixed: '#002111'
  on-secondary-fixed-variant: '#0f5132'
  tertiary-fixed: '#dae2ff'
  tertiary-fixed-dim: '#b1c5ff'
  on-tertiary-fixed: '#001946'
  on-tertiary-fixed-variant: '#00419e'
  background: '#f8f9fa'
  on-background: '#191c1d'
  surface-variant: '#e1e3e4'
typography:
  display-hero:
    fontFamily: Inter
    fontSize: 2.5rem
    fontWeight: '700'
    lineHeight: 3rem
    letterSpacing: -0.02em
  headline-lg:
    fontFamily: Inter
    fontSize: 2rem
    fontWeight: '700'
    lineHeight: 2.5rem
    letterSpacing: -0.015em
  headline-lg-mobile:
    fontFamily: Inter
    fontSize: 1.5rem
    fontWeight: '700'
    lineHeight: 2rem
    letterSpacing: -0.01em
  headline-md:
    fontFamily: Inter
    fontSize: 1.5rem
    fontWeight: '600'
    lineHeight: 2rem
    letterSpacing: -0.01em
  headline-sm:
    fontFamily: Inter
    fontSize: 1.25rem
    fontWeight: '600'
    lineHeight: 1.75rem
    letterSpacing: -0.005em
  title-md:
    fontFamily: Inter
    fontSize: 1rem
    fontWeight: '600'
    lineHeight: 1.5rem
  body-lg:
    fontFamily: Inter
    fontSize: 1.125rem
    fontWeight: '400'
    lineHeight: 1.75rem
  body-md:
    fontFamily: Inter
    fontSize: 1rem
    fontWeight: '400'
    lineHeight: 1.5rem
  body-sm:
    fontFamily: Inter
    fontSize: 0.875rem
    fontWeight: '400'
    lineHeight: 1.25rem
  label-md:
    fontFamily: Inter
    fontSize: 0.875rem
    fontWeight: '600'
    lineHeight: 1.25rem
    letterSpacing: 0.02em
  label-sm:
    fontFamily: Inter
    fontSize: 0.75rem
    fontWeight: '600'
    lineHeight: 1rem
    letterSpacing: 0.04em
  slot-time:
    fontFamily: Inter
    fontSize: 0.8125rem
    fontWeight: '700'
    lineHeight: 1rem
rounded:
  sm: 0.25rem
  DEFAULT: 0.5rem
  md: 0.75rem
  lg: 1rem
  xl: 1.5rem
  full: 9999px
spacing:
  gutter: 1.5rem
  gutter-sm: 0.75rem
  margin: 1.5rem
  margin-mobile: 1rem
  space-xs: 0.25rem
  space-sm: 0.5rem
  space-md: 1rem
  space-lg: 1.5rem
  space-xl: 2rem
  space-xxl: 3rem
---

## Brand & Style

This design system is tailored for collegiate and institutional sports facility administration, court reservations, and athletics management. The brand personality emphasizes dependability, academic structure, precision scheduling, and athletic vitality. It serves students, athletic directors, campus recreation staff, and community leagues who require zero-friction booking and clear operational clarity.

The visual style employs a modern, utility-first corporate aesthetic rooted in standard Bootstrap 5 conventions. Crisp white functional cards sit upon light slate-tinted neutral canvases, anchored by authoritative athletic green accents. Typography is strictly utilitarian, highly legible, and objective, creating an interface that feels official, organized, and capable under heavy daily usage.

## Colors

The palette establishes an immediate connection to classic playing fields, indoor turf, and court surfaces while maintaining strict WCAG 2.1 AA contrast compliance across data-dense views.

- **Primary (`#198754`)**: Standard sports green. Used for affirmative actions, primary buttons (`.btn-success`), active slot selections, confirmed reservation badges, and active navigation indicators.
- **Secondary (`#0f5132`)**: Deep court green. Utilized for high-contrast contextual states, focused table rows, solid banner callouts, and dark card headers requiring institutional authority.
- **Tertiary (`#0d6efd`)**: Athletic blue. Used selectively for secondary system utilities, administrative actions (`.btn-primary`), and link states to distinguish management features from court availability.
- **Neutral (`#f8f9fa`)**: Clean slate neutral. Forms the page-level background canvas to soften glare in indoor administrative lighting, contrasting cleanly with pure white card surfaces (`#ffffff`) and slate borders (`#dee2e6`).
- **State Semantics**: Reserved/Occupied (`#dc3545`), Pending/Maintenance (`#ffc107`), and Open/Available (`#198754`).

## Typography

Inter serves as the unified family for all roles, offering tabular numerals and uniform vertical metrics ideal for booking matrices, schedule timelines, and financial tallies.

- **Headlines & Page Titles**: Bold weights (`700`) with tight letter spacing for facility names, court headers, and dashboard summaries.
- **Body Text**: Regular weights (`400`) at comfortable line heights (`1.5rem`) for schedule policies, reservation terms, and student guidelines.
- **Labels & Micro-copy**: Semibold weights (`600` or `700`) with positive tracking for column headers, status badges, and slot pill text to maintain legibility when rendered in compact UI spaces.

## Layout & Spacing

The layout model is built upon the standard 12-column responsive fluid grid conforming to Bootstrap 5 container constraints:
- **Mobile (<768px)**: 100% fluid width with `1rem` outer margins and `0.75rem` gutters. Stacks court selectors, filters, and slot lists vertically.
- **Tablet (768px–1024px)**: 12-column grid with `1.5rem` gutters. Supports a split view: filters and facility meta span 4 columns; daily court matrices span 8 columns.
- **Desktop (>1024px)**: Fixed containers (max `1320px` at `xxl`) with `1.5rem` gutters. Accommodates standard side-by-side management layouts: persistent navigation, multi-court schedules, and checkout side-panels.

Internal component rhythm operates on a 4px/8px modular scale (`space-xs` through `space-xxl`), guaranteeing vertical alignment across complex ASP.NET MVC Razor view components and tabular grids.

## Elevation & Depth

This system avoids heavy drop shadows and glass effects in favor of clean architectural planes, subtle border delineation, and purposeful elevation tiers:

- **Flat/Base Surface**: White (`#ffffff`) panels resting on Canvas Neutral (`#f8f9fa`) with a 1px solid border in `#dee2e6`.
- **Level 1 (Cards & Data Tables)**: `0 1px 3px rgba(0, 0, 0, 0.05), 0 1px 2px rgba(0, 0, 0, 0.03)` with a 1px border (`#dee2e6`). Used for standard facility cards, summary cards, and form containers.
- **Level 2 (Hover States & Dropdowns)**: `0 4px 6px -1px rgba(0, 0, 0, 0.08), 0 2px 4px -1px rgba(0, 0, 0, 0.04)`. Applied to active card hovers, slot selector selection states, and dropdown menus.
- **Level 3 (Modals & Reservation Flyouts)**: `0 10px 15px -3px rgba(0, 0, 0, 0.1), 0 4px 6px -2px rgba(0, 0, 0, 0.05)`. Reserved for confirmation modals, conflict resolution dialogs, and sticky booking drawers.

## Shapes

The design uses standard rounded geometry (`roundedness: 2` / base `0.5rem`). This value delivers a refined balance between modern software design and institutional structure.

- **Cards & Data Panels**: `0.5rem` (`rounded-2`) to keep corners compact and structurally stable in dense layouts.
- **Buttons & Input Fields**: `0.375rem` to `0.5rem` (`rounded-2`) matching native Bootstrap 5 conventions.
- **Slot Selector Chips & Badges**: Fully rounded (`rounded-pill` / `50rem`) to visually differentiate transient selections and status markers from rectangular structural containers.
- **Images**: Card header banners use top-rounded corners (`0.5rem 0.5rem 0 0`) matching the parent container.

## Components

### Buttons
- **Primary Athletic (`.btn-success`)**: Solid `#198754`, white text, semibold weight. Used for the primary call-to-action (e.g., "Confirm Booking", "Save Schedule").
- **Secondary Action (`.btn-outline-success`)**: White background, 1.5px border `#198754`, `#198754` text. Inverts on hover to solid `#198754`. Used for slot selection and secondary court options.
- **Administrative (`.btn-primary`)**: Solid `#0d6efd`, used exclusively for high-level management operations (e.g., "Export Roster", "Create Facility").

### Slot Selector Chips
- **Available State**: `.rounded-pill`, padding `0.375rem 0.875rem`, border `1px solid #198754`, background `#ffffff`, text `#198754`.
- **Selected State**: Background `#198754`, border `1px solid #198754`, text `#ffffff`, shadow `0 2px 4px rgba(25, 135, 84, 0.25)`.
- **Booked / Disabled State**: Background `#e9ecef`, border `1px solid #ced4da`, text `#6c757d`, strikethrough or lock icon, cursor not-allowed.

### Cards & Court Modules
- Structure: White `#ffffff` background, `1px solid #dee2e6`, `0.5rem` radius.
- Header Image: Full bleed across the top, `160px` fixed height, object-fit cover, with rounded top corners.
- Body: `1.25rem` internal padding containing sport category badge, court name, surface type label, and hourly rate.
- Footer: Distinct border-top (`#e9ecef`), housing slot availability counters and direct action buttons.

### Badges & Status Pills
- Applied via `.badge.rounded-pill` with high-contrast text:
  - Confirmed/Active: `.bg-success` (`#198754`)
  - Closed/Maintenance: `.bg-danger` (`#dc3545`)
  - Pending Payment: `.bg-warning.text-dark` (`#ffc107`)
  - Academic Priority: `.bg-secondary` (`#0f5132`)

### Form Inputs & Tabular Layouts
- Form inputs feature a crisp 1px border (`#ced4da`), focusing to a `#198754` outline with an alpha shadow (`rgba(25, 135, 84, 0.25)`).
- Data tables feature uppercase semibold headers (`#495057`) with subtle border separators (`#dee2e6`), alternating row striping (`#f8f9fa`), and vertically aligned action cells.